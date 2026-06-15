namespace FacebookSharp.Videos.Models.Request;

public class VideoGetRequest
{
    public string VideoId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,created_time,length,description,permalink_url";
}
