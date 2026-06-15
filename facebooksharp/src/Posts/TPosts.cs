using RestSharp;
using FacebookSharp.Posts.Models.Request;
using FacebookSharp.Posts.Models.Response;

namespace FacebookSharp.Posts;

public class TPosts : IPosts
{
    private readonly IRestClient _client;

    public TPosts(IRestClient client) => _client = client;

    public RestResponse<Post> Get(PostGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PostId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Post>(request);
    }

    public RestResponse<PostCommentCollection> GetComments(PostCommentsGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PostId}/comments", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<PostCommentCollection>(request);
    }
}