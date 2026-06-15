namespace FacebookSharp.Videos.Models.Request;

public class VideoFeedGetRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,created_time,length";
    public string? Limit { get; set; }
}