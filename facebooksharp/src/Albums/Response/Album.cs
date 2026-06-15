using Newtonsoft.Json;

namespace FacebookSharp.Albums.Models.Response;

public class Album
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("count")]
    public int? Count { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("link")]
    public string? Link { get; set; }
}
