using RestSharp;
using FacebookSharp.Videos.Models.Request;
using FacebookSharp.Videos.Models.Response;

namespace FacebookSharp.Videos;

public class TVideos : IVideos
{
    private readonly IRestClient _client;

    public TVideos(IRestClient client) => _client = client;

    public RestResponse<Video> Get(VideoGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.VideoId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Video>(request);
    }

    public RestResponse<VideoCollection> GetFeed(VideoFeedGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/videos", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<VideoCollection>(request);
    }
}