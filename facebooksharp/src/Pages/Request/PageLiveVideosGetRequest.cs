namespace FacebookSharp.Pages.Models.Request;

public class PageLiveVideosGetRequest
{
    public string PageId { get; set; } = default!;
    public string? Fields { get; set; } = "id,status,creation_time";
}