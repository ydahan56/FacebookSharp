using RestSharp;
using FacebookSharp.Likes.Models.Request;
using FacebookSharp.Likes.Models.Response;

namespace FacebookSharp.Likes;

public class TLikes : ILikes
{
    private readonly IRestClient _client;

    public TLikes(IRestClient client) => _client = client;

    public RestResponse<LikeCollection> GetList(LikesListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/likes", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        request.AddQueryParameter("summary", "total_count");
        return _client.Execute<LikeCollection>(request);
    }

    public RestResponse<Like> Get(LikeRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.LikeId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Like>(request);
    }
}
