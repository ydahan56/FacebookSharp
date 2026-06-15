using RestSharp;
using FacebookSharp.Feed.Models.Request;
using FacebookSharp.Feed.Models.Response;

namespace FacebookSharp.Feed;

public class TFeed : IFeed
{
    private readonly IRestClient _client;

    public TFeed(IRestClient client) => _client = client;

    public RestResponse<FeedCollection> GetUserFeed(UserFeedRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}/feed", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<FeedCollection>(request);
    }

    public RestResponse<FeedCollection> GetFeed(FeedPostsRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/feed", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<FeedCollection>(request);
    }
}
