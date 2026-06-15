using Newtonsoft.Json;

namespace FacebookSharp.Photos.Models.Response;

public class Photo
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("picture")]
    public string? Picture { get; set; }

    [JsonProperty("source")]
    public string? Source { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("from")]
    public PhotoFrom? From { get; set; }
}

public class PhotoFrom
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}
