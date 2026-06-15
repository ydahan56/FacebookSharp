using Newtonsoft.Json;

namespace FacebookSharp.Videos.Models.Response;

public class Video
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("length")]
    public double? Length { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("permalink_url")]
    public string? PermalinkUrl { get; set; }
}
