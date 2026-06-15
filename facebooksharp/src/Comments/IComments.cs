using FacebookSharp.Comments.Models.Request;
using FacebookSharp.Comments.Models.Response;
using RestSharp;

namespace FacebookSharp.Comments;

public interface IComments
{
    RestResponse<Comment> Get(CommentGetRequest requestModel);
    RestResponse<CommentCollection> GetReplies(CommentRepliesGetRequest requestModel);
    RestResponse<CreateCommentResponse> Create(CommentCreateRequest requestModel);
    RestResponse Delete(CommentDeleteRequest requestModel);
}