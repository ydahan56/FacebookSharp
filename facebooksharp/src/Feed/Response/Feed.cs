using Newtonsoft.Json;

namespace FacebookSharp.Feed.Models.Response;

public class FeedPost
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("story")]
    public string? Story { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("permalink_url")]
    public string? PermalinkUrl { get; set; }

    [JsonProperty("from")]
    public FeedFrom? From { get; set; }
}

public class FeedFrom
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}

public class FeedCollection
{
    [JsonProperty("data")]
    public List<FeedPost> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
