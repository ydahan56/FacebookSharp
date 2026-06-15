namespace FacebookSharp.Conversations.Models.Request;

public class ConversationsListRequest
{
    public string UserId { get; set; } = default!;
    public string? Fields { get; set; } = "id,former_participants,senders,subject,updated_time,wallpaper";
    public string? Limit { get; set; }
}

public class ConversationRequest
{
    public string ConversationId { get; set; } = default!;
    public string? Fields { get; set; } = "id,former_participants,senders,subject,updated_time";
}

public class ConversationMessagesRequest
{
    public string ConversationId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,from,sticker";
    public string? Limit { get; set; }
}
