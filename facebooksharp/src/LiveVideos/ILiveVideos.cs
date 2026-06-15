using FacebookSharp.LiveVideos.Models.Request;
using FacebookSharp.LiveVideos.Models.Response;
using RestSharp;

namespace FacebookSharp.LiveVideos;

public interface ILiveVideos
{
    RestResponse<LiveVideoCollection> GetList(LiveVideosListRequest requestModel);
    RestResponse<LiveVideo> Get(LiveVideoRequest requestModel);
    RestResponse<LiveVideoCommentCollection> GetComments(LiveVideoCommentsRequest requestModel);
}
