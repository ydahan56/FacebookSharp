namespace FacebookSharp.Posts.Models.Request;

public class PostCommentsGetRequest
{
    public string PostId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,from";
    public string? Limit { get; set; }
}