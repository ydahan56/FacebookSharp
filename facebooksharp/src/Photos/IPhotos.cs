using FacebookSharp.Photos.Models.Request;
using FacebookSharp.Photos.Models.Response;
using RestSharp;

namespace FacebookSharp.Photos;

public interface IPhotos
{
    RestResponse<Photo> Get(PhotoGetRequest requestModel);
    RestResponse<PhotoCollection> GetAll(PhotosGetRequest requestModel);
}
