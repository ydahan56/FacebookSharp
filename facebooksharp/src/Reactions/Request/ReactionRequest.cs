namespace FacebookSharp.Reactions.Models.Request;

public class ReactionsListRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture,type";
    public string? Limit { get; set; }
}

public class ReactionRequest
{
    public string ReactionId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture,type";
}
