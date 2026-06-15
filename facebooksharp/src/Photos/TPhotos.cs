using RestSharp;
using FacebookSharp.Photos.Models.Request;
using FacebookSharp.Photos.Models.Response;

namespace FacebookSharp.Photos;

public class TPhotos : IPhotos
{
    private readonly IRestClient _client;

    public TPhotos(IRestClient client) => _client = client;

    public RestResponse<Photo> Get(PhotoGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PhotoId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Photo>(request);
    }

    public RestResponse<PhotoCollection> GetAll(PhotosGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/photos", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<PhotoCollection>(request);
    }
}
