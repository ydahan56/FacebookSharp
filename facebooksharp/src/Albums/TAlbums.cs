using RestSharp;
using FacebookSharp.Albums.Models.Request;
using FacebookSharp.Albums.Models.Response;

namespace FacebookSharp.Albums;

public class TAlbums : IAlbums
{
    private readonly IRestClient _client;

    public TAlbums(IRestClient client) => _client = client;

    public RestResponse<Album> Get(AlbumGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.AlbumId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Album>(request);
    }

    public RestResponse<AlbumCollection> GetFeed(AlbumFeedGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/albums", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<AlbumCollection>(request);
    }

    public RestResponse<PhotoCollection> GetPhotos(AlbumPhotosGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.AlbumId}/photos", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<PhotoCollection>(request);
    }
}