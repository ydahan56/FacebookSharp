namespace FacebookSharp.Photos.Models.Request;

public class PhotoGetRequest
{
    public string PhotoId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture,source,created_time,from";
}
