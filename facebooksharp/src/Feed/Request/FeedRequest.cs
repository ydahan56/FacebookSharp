namespace FacebookSharp.Feed.Models.Request;

public class UserFeedRequest
{
    public string UserId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,permalink_url,from,story";
    public string? Limit { get; set; }
}

public class FeedPostsRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,permalink_url,from";
    public string? Limit { get; set; }
}
