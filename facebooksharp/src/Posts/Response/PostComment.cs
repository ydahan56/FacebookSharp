using Newtonsoft.Json;

namespace FacebookSharp.Posts.Models.Response;

public class PostComment
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("from")]
    public PostFrom? From { get; set; }
}