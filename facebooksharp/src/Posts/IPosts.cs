using FacebookSharp.Posts.Models.Request;
using FacebookSharp.Posts.Models.Response;
using RestSharp;

namespace FacebookSharp.Posts;

public interface IPosts
{
    RestResponse<Post> Get(PostGetRequest requestModel);
    RestResponse<PostCommentCollection> GetComments(PostCommentsGetRequest requestModel);
}