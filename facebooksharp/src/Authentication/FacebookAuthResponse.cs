using Newtonsoft.Json;

namespace FacebookSharp.Authentication;

public class FacebookAuthResponse
{
    [JsonProperty("access_token")]
    public string? AccessToken { get; set; }

    [JsonProperty("token_type")]
    public string? TokenType { get; set; }

    [JsonProperty("expires_in")]
    public int? ExpiresIn { get; set; }

    [JsonProperty("error")]
    public FacebookAuthError? Error { get; set; }
}

public class FacebookAuthError
{
    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("code")]
    public int? Code { get; set; }
}
