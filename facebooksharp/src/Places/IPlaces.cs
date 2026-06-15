using FacebookSharp.Places.Models.Request;
using FacebookSharp.Places.Models.Response;
using RestSharp;

namespace FacebookSharp.Places;

public interface IPlaces
{
    RestResponse<Place> Get(PlaceRequest requestModel);
    RestResponse<PlaceCollection> Search(PlacesSearchRequest requestModel);
}
