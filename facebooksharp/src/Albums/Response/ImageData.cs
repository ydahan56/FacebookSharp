using Newtonsoft.Json;

namespace FacebookSharp.Albums.Models.Response;

public class ImageData
{
    [JsonProperty("source")]
    public string? Source { get; set; }

    [JsonProperty("height")]
    public int? Height { get; set; }

    [JsonProperty("width")]
    public int? Width { get; set; }
}