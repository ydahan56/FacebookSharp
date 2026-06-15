namespace FacebookSharp.Pages.Models.Request;

public class PageGetRequest
{
    public string PageId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,about,picture,link,followers_count";
}
