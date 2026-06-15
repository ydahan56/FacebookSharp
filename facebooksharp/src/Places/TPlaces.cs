using RestSharp;
using FacebookSharp.Places.Models.Request;
using FacebookSharp.Places.Models.Response;

namespace FacebookSharp.Places;

public class TPlaces : IPlaces
{
    private readonly IRestClient _client;

    public TPlaces(IRestClient client) => _client = client;

    public RestResponse<Place> Get(PlaceRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PlaceId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Place>(request);
    }

    public RestResponse<PlaceCollection> Search(PlacesSearchRequest requestModel)
    {
        var request = new RestRequest("/search", Method.Get);
        request.AddQueryParameter("type", "place");
        if (requestModel.Latitude.HasValue)
            request.AddQueryParameter("center", $"{requestModel.Latitude},{requestModel.Longitude}");
        if (!string.IsNullOrWhiteSpace(requestModel.Distance))
            request.AddQueryParameter("distance", requestModel.Distance);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<PlaceCollection>(request);
    }
}
