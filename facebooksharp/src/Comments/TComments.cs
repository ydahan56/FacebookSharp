using RestSharp;
using FacebookSharp.Comments.Models.Request;
using FacebookSharp.Comments.Models.Response;

namespace FacebookSharp.Comments;

public class TComments : IComments
{
    private readonly IRestClient _client;

    public TComments(IRestClient client) => _client = client;

    public RestResponse<Comment> Get(CommentGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.CommentId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Comment>(request);
    }

    public RestResponse<CommentCollection> GetReplies(CommentRepliesGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.CommentId}/replies", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<CommentCollection>(request);
    }

    public RestResponse<CreateCommentResponse> Create(CommentCreateRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PostId}/comments", Method.Post);
        request.AddParameter("message", requestModel.Message);
        return _client.Execute<CreateCommentResponse>(request);
    }

    public RestResponse Delete(CommentDeleteRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.CommentId}", Method.Delete);
        return _client.Execute(request);
    }
}