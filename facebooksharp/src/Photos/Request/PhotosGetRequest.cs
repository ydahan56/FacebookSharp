namespace FacebookSharp.Photos.Models.Request;

public class PhotosGetRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture,created_time,from";
    public string? Limit { get; set; }
}
