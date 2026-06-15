using FacebookSharp.Videos.Models.Request;
using FacebookSharp.Videos.Models.Response;
using RestSharp;

namespace FacebookSharp.Videos;

public interface IVideos
{
    RestResponse<Video> Get(VideoGetRequest requestModel);
    RestResponse<VideoCollection> GetFeed(VideoFeedGetRequest requestModel);
}