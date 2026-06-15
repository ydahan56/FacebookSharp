using Newtonsoft.Json;

namespace FacebookSharp.Notifications.Models.Response;

public class Notification
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("link")]
    public string? Link { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("object")]
    public NotificationObject? Object { get; set; }
}

public class NotificationObject
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}

public class NotificationCollection
{
    [JsonProperty("data")]
    public List<Notification> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
