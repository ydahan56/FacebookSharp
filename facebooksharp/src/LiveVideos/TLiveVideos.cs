using RestSharp;
using FacebookSharp.LiveVideos.Models.Request;
using FacebookSharp.LiveVideos.Models.Response;

namespace FacebookSharp.LiveVideos;

public class TLiveVideos : ILiveVideos
{
    private readonly IRestClient _client;

    public TLiveVideos(IRestClient client) => _client = client;

    public RestResponse<LiveVideoCollection> GetList(LiveVideosListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}/live_videos", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<LiveVideoCollection>(request);
    }

    public RestResponse<LiveVideo> Get(LiveVideoRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.LiveVideoId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<LiveVideo>(request);
    }

    public RestResponse<LiveVideoCommentCollection> GetComments(LiveVideoCommentsRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.LiveVideoId}/comments", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<LiveVideoCommentCollection>(request);
    }
}
