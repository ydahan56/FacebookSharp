namespace FacebookSharp.Likes.Models.Request;

public class LikesListRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture";
    public string? Limit { get; set; }
}

public class LikeRequest
{
    public string LikeId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture";
}
