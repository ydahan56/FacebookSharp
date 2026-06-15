namespace FacebookSharp.Pages.Models.Request;

public class PageFeedGetRequest
{
    public string PageId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,permalink_url";
    public string? Limit { get; set; }
    public string? After { get; set; }
    public string? Before { get; set; }
}
