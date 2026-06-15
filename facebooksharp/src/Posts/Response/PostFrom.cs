using Newtonsoft.Json;

namespace FacebookSharp.Posts.Models.Response;

public class PostFrom
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}
