using Newtonsoft.Json;

namespace FacebookSharp.LiveVideos.Models.Response;

public class LiveVideo
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("status")]
    public string? Status { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("permalink_url")]
    public string? PermalinkUrl { get; set; }

    [JsonProperty("embed_html")]
    public string? EmbedHtml { get; set; }

    [JsonProperty("from")]
    public LiveVideoFrom? From { get; set; }
}

public class LiveVideoFrom
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}

public class LiveVideoCollection
{
    [JsonProperty("data")]
    public List<LiveVideo> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}

public class LiveVideoComment
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("from")]
    public LiveVideoFrom? From { get; set; }
}

public class LiveVideoCommentCollection
{
    [JsonProperty("data")]
    public List<LiveVideoComment> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
