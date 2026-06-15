using RestSharp;
using FacebookSharp.Friends.Models.Request;
using FacebookSharp.Friends.Models.Response;

namespace FacebookSharp.Friends;

public class TFriends : IFriends
{
    private readonly IRestClient _client;

    public TFriends(IRestClient client) => _client = client;

    public RestResponse<FriendCollection> GetList(FriendsListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}/friends", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<FriendCollection>(request);
    }

    public RestResponse<Friend> Get(FriendRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.FriendId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Friend>(request);
    }
}
