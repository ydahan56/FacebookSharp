using FacebookSharp.Feed.Models.Request;
using FacebookSharp.Feed.Models.Response;
using RestSharp;

namespace FacebookSharp.Feed;

public interface IFeed
{
    RestResponse<FeedCollection> GetUserFeed(UserFeedRequest requestModel);
    RestResponse<FeedCollection> GetFeed(FeedPostsRequest requestModel);
}
