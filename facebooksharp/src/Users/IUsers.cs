using FacebookSharp.Users.Models.Request;
using FacebookSharp.Users.Models.Response;
using RestSharp;

namespace FacebookSharp.Users;

public interface IUsers
{
    RestResponse<User> Get(UserGetRequest requestModel);
    RestResponse<UserPicture> GetPicture(UserPictureGetRequest requestModel);
}