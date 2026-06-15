namespace FacebookSharp.Comments.Models.Request;

public class CommentGetRequest
{
    public string CommentId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,from";
}

public class CommentRepliesGetRequest
{
    public string CommentId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,from";
    public string? Limit { get; set; }
}

public class CommentCreateRequest
{
    public string PostId { get; set; } = default!;
    public string Message { get; set; } = default!;
}

public class CommentDeleteRequest
{
    public string CommentId { get; set; } = default!;
}