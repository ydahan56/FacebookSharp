namespace FacebookSharp.Posts.Models.Request;

public class PostGetRequest
{
    public string PostId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,permalink_url,from";
}
