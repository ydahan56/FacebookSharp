using FacebookSharp.Friends.Models.Request;
using FacebookSharp.Friends.Models.Response;
using RestSharp;

namespace FacebookSharp.Friends;

public interface IFriends
{
    RestResponse<FriendCollection> GetList(FriendsListRequest requestModel);
    RestResponse<Friend> Get(FriendRequest requestModel);
}
