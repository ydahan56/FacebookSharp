namespace FacebookSharp.Albums.Models.Request;

public class AlbumPhotosGetRequest
{
    public string AlbumId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,created_time,images";
    public string? Limit { get; set; }
}