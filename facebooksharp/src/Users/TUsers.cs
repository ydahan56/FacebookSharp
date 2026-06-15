using RestSharp;
using FacebookSharp.Users.Models.Request;
using FacebookSharp.Users.Models.Response;

namespace FacebookSharp.Users;

public class TUsers : IUsers
{
    private readonly IRestClient _client;

    public TUsers(IRestClient client) => _client = client;

    public RestResponse<User> Get(UserGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<User>(request);
    }

    public RestResponse<UserPicture> GetPicture(UserPictureGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}/picture", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Width))
            request.AddQueryParameter("width", requestModel.Width);
        if (!string.IsNullOrWhiteSpace(requestModel.Height))
            request.AddQueryParameter("height", requestModel.Height);
        return _client.Execute<UserPicture>(request);
    }
}