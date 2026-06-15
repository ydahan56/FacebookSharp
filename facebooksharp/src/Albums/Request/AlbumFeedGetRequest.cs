namespace FacebookSharp.Albums.Models.Request;

public class AlbumFeedGetRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,count,created_time";
    public string? Limit { get; set; }
}
