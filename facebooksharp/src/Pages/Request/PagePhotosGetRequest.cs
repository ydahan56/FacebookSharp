namespace FacebookSharp.Pages.Models.Request;

public class PagePhotosGetRequest
{
    public string PageId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,created_time,images";
}
