using RestSharp;
using FacebookSharp.Milestones.Models.Request;
using FacebookSharp.Milestones.Models.Response;

namespace FacebookSharp.Milestones;

public class TMilestones : IMilestones
{
    private readonly IRestClient _client;

    public TMilestones(IRestClient client) => _client = client;

    public RestResponse<MilestoneCollection> GetList(MilestonesListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}/milestones", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<MilestoneCollection>(request);
    }

    public RestResponse<Milestone> Get(MilestoneRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.MilestoneId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Milestone>(request);
    }
}
