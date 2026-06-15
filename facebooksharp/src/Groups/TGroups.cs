using RestSharp;
using FacebookSharp.Groups.Models.Request;
using FacebookSharp.Groups.Models.Response;

namespace FacebookSharp.Groups;

public class TGroups : IGroups
{
    private readonly IRestClient _client;

    public TGroups(IRestClient client) => _client = client;

    public RestResponse<Group> Get(GroupGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.GroupId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Group>(request);
    }

    public RestResponse<GroupCollection> GetList(GroupsListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}/groups", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<GroupCollection>(request);
    }

    public RestResponse<GroupMemberCollection> GetMembers(GroupMembersRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.GroupId}/members", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<GroupMemberCollection>(request);
    }

    public RestResponse<GroupCollection> GetFeed(GroupFeedRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.GroupId}/feed", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<GroupCollection>(request);
    }
}
