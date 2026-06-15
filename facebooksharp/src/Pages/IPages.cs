using FacebookSharp.Pages.Models.Request;
using FacebookSharp.Pages.Models.Response;
using RestSharp;

namespace FacebookSharp.Pages;

public interface IPages
{
    RestResponse<Page> Get(PageGetRequest requestModel);
    RestResponse<PagePostCollection> GetFeed(PageFeedGetRequest requestModel);
    RestResponse<PagePostCollection> GetPosts(PagePostsGetRequest requestModel);
    RestResponse<PagePhotoCollection> GetPhotos(PagePhotosGetRequest requestModel);
    RestResponse<PageVideoCollection> GetVideos(PageVideosGetRequest requestModel);
    RestResponse<PageLiveVideoCollection> GetLiveVideos(PageLiveVideosGetRequest requestModel);
}