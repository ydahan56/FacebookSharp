using Newtonsoft.Json;

namespace FacebookSharp.Videos.Models.Response;

public class VideoCollection
{
    [JsonProperty("data")]
    public List<Video> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}