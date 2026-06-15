using RestSharp;
using FacebookSharp.Pages.Models.Request;
using FacebookSharp.Pages.Models.Response;

namespace FacebookSharp.Pages;

public class TPages : IPages
{
    private readonly IRestClient _client;

    public TPages(IRestClient client) => _client = client;

    public RestResponse<Page> Get(PageGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Page>(request);
    }

    public RestResponse<PagePostCollection> GetFeed(PageFeedGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}/feed", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        if (!string.IsNullOrWhiteSpace(requestModel.After))
            request.AddQueryParameter("after", requestModel.After);
        if (!string.IsNullOrWhiteSpace(requestModel.Before))
            request.AddQueryParameter("before", requestModel.Before);
        return _client.Execute<PagePostCollection>(request);
    }

    public RestResponse<PagePostCollection> GetPosts(PagePostsGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}/posts", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<PagePostCollection>(request);
    }

    public RestResponse<PagePhotoCollection> GetPhotos(PagePhotosGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}/photos", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<PagePhotoCollection>(request);
    }

    public RestResponse<PageVideoCollection> GetVideos(PageVideosGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}/videos", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<PageVideoCollection>(request);
    }

    public RestResponse<PageLiveVideoCollection> GetLiveVideos(PageLiveVideosGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}/live_videos", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<PageLiveVideoCollection>(request);
    }
}