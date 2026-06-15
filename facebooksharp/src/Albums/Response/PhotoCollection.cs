using Newtonsoft.Json;

namespace FacebookSharp.Albums.Models.Response;

public class PhotoCollection
{
    [JsonProperty("data")]
    public List<Photo> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
