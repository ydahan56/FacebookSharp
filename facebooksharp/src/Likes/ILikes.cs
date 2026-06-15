using FacebookSharp.Likes.Models.Request;
using FacebookSharp.Likes.Models.Response;
using RestSharp;

namespace FacebookSharp.Likes;

public interface ILikes
{
    RestResponse<LikeCollection> GetList(LikesListRequest requestModel);
    RestResponse<Like> Get(LikeRequest requestModel);
}
