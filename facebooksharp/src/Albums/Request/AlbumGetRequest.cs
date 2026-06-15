namespace FacebookSharp.Albums.Models.Request;

public class AlbumGetRequest
{
    public string AlbumId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,count,created_time,link";
}
