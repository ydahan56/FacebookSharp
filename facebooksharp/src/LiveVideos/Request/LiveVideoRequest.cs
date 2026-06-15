namespace FacebookSharp.LiveVideos.Models.Request;

public class LiveVideosListRequest
{
    public string UserId { get; set; } = default!;
    public string? Fields { get; set; } = "id,title,description,status,created_time,permalink_url,embed_html";
    public string? Limit { get; set; }
}

public class LiveVideoRequest
{
    public string LiveVideoId { get; set; } = default!;
    public string? Fields { get; set; } = "id,title,description,status,created_time,permalink_url,embed_html";
}

public class LiveVideoCommentsRequest
{
    public string LiveVideoId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,from";
    public string? Limit { get; set; }
}
