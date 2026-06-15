using RestSharp;
using System.Text.Json;

namespace FacebookSharp.Authentication;

public class FacebookAuth
{
    private readonly string _appId;
    private readonly string _appSecret;
    private readonly string _redirectUri;
    private readonly IRestClient _client;

    public FacebookAuth(string appId, string appSecret, string redirectUri)
    {
        _appId = appId;
        _appSecret = appSecret;
        _redirectUri = redirectUri;
        _client = new RestClient(new RestClientOptions("https://www.facebook.com"));
    }

    public string BuildLoginUrl(string scope = "public_profile,user_pages,pages_manage_posts", string? state = null)
    {
        var baseUrl = "https://www.facebook.com/dialog/oauth";
        var parameters = new Dictionary<string, string>
        {
            ["client_id"] = _appId,
            ["redirect_uri"] = _redirectUri,
            ["response_type"] = "code",
            ["scope"] = scope
        };

        if (!string.IsNullOrWhiteSpace(state))
            parameters["state"] = state;

        var queryString = string.Join("&", parameters.Select(p => $"{p.Key}={Uri.EscapeDataString(p.Value)}"));
        return $"{baseUrl}?{queryString}";
    }

    public async Task<FacebookAuthResponse> ExchangeCodeForUserTokenAsync(string code, CancellationToken ct = default)
    {
        var request = new RestRequest("/v25.0/oauth/access_token", Method.Get);
        request.AddQueryParameter("client_id", _appId);
        request.AddQueryParameter("client_secret", _appSecret);
        request.AddQueryParameter("code", code);

        var response = await _client.ExecuteAsync<FacebookAuthResponse>(request, ct).ConfigureAwait(false);
        if (!response.IsSuccessful)
            throw new AuthException($"Failed to exchange code for user token: {response.StatusDescription}", response.Content);

        return response.Data ?? throw new AuthException("No auth data returned", response.Content);
    }

    public async Task<FacebookAuthResponse> ExchangeForLongLivedUserTokenAsync(string shortLivedToken, CancellationToken ct = default)
    {
        var request = new RestRequest("/v25.0/oauth/access_token", Method.Get);
        request.AddQueryParameter("client_id", _appId);
        request.AddQueryParameter("client_secret", _appSecret);
        request.AddQueryParameter("grant_type", "fb_exchange_token");
        request.AddQueryParameter("fb_exchange_token", shortLivedToken);

        var response = await _client.ExecuteAsync<FacebookAuthResponse>(request, ct).ConfigureAwait(false);
        if (!response.IsSuccessful)
            throw new AuthException($"Failed to exchange for long-lived token: {response.StatusDescription}", response.Content);

        return response.Data ?? throw new AuthException("No long-lived token returned", response.Content);
    }

    public async Task<string> GetPageAccessTokenAsync(string userToken, string pageId, CancellationToken ct = default)
    {
        var request = new RestRequest($"/{pageId}", Method.Get);
        request.AddQueryParameter("fields", "access_token");
        request.AddQueryParameter("access_token", userToken);

        var response = await _client.ExecuteAsync(request, ct).ConfigureAwait(false);
        if (!response.IsSuccessful)
            throw new AuthException($"Failed to get page access token: {response.StatusDescription}", response.Content);

        var json = response.Content;
        if (string.IsNullOrWhiteSpace(json))
            throw new AuthException("No response content when getting page access token", json);

        using var doc = JsonDocument.Parse(json);
        var tokenNode = doc.RootElement.GetProperty("access_token");
        return tokenNode.GetString() ?? throw new AuthException("No access_token field in response", json);
    }

    public async Task<string> GetAppAccessTokenAsync(CancellationToken ct = default)
    {
        var request = new RestRequest("/oauth/access_token", Method.Post);
        request.AddParameter("client_id", _appId);
        request.AddParameter("client_secret", _appSecret);
        request.AddParameter("grant_type", "client_credentials");

        var response = await _client.ExecuteAsync<FacebookAuthResponse>(request, ct).ConfigureAwait(false);
        if (!response.IsSuccessful)
            throw new AuthException($"Failed to get app access token: {response.StatusDescription}", response.Content);

        var data = response.Data ?? throw new AuthException("No auth data returned", response.Content);
        return data.AccessToken ?? throw new AuthException("No access_token in response", response.Content);
    }
}
