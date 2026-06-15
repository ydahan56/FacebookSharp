using RestSharp;
using FacebookSharp.Reactions.Models.Request;
using FacebookSharp.Reactions.Models.Response;

namespace FacebookSharp.Reactions;

public class TReactions : IReactions
{
    private readonly IRestClient _client;

    public TReactions(IRestClient client) => _client = client;

    public RestResponse<ReactionCollection> GetList(ReactionsListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/reactions", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        request.AddQueryParameter("summary", "total_count,viewer_reaction");
        return _client.Execute<ReactionCollection>(request);
    }

    public RestResponse<Reaction> Get(ReactionRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ReactionId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Reaction>(request);
    }
}
