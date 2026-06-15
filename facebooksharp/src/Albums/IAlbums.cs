using FacebookSharp.Albums.Models.Request;
using FacebookSharp.Albums.Models.Response;
using RestSharp;

namespace FacebookSharp.Albums;

public interface IAlbums
{
    RestResponse<Album> Get(AlbumGetRequest requestModel);
    RestResponse<AlbumCollection> GetFeed(AlbumFeedGetRequest requestModel);
    RestResponse<PhotoCollection> GetPhotos(AlbumPhotosGetRequest requestModel);
}