namespace FacebookSharp.Pages.Models.Request;

public class PagePostsGetRequest
{
    public string PageId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,permalink_url";
    public string? Limit { get; set; }
}
