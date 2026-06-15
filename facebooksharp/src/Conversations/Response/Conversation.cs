using Newtonsoft.Json;

namespace FacebookSharp.Conversations.Models.Response;

public class Conversation
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("subject")]
    public string? Subject { get; set; }

    [JsonProperty("updated_time")]
    public string? UpdatedTime { get; set; }

    [JsonProperty("senders")]
    public List<ConversationParticipant>? Senders { get; set; }

    [JsonProperty("former_participants")]
    public List<ConversationParticipant>? FormerParticipants { get; set; }

    [JsonProperty("wallpaper")]
    public string? Wallpaper { get; set; }
}

public class ConversationParticipant
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }
}

public class ConversationMessage
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("from")]
    public ConversationFrom? From { get; set; }

    [JsonProperty("sticker")]
    public string? Sticker { get; set; }
}

public class ConversationFrom
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }
}

public class ConversationCollection
{
    [JsonProperty("data")]
    public List<Conversation> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}

public class ConversationMessageCollection
{
    [JsonProperty("data")]
    public List<ConversationMessage> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
