using Newtonsoft.Json;

namespace FacebookSharp.Albums.Models.Response;

public class AlbumCollection
{
    [JsonProperty("data")]
    public List<Album> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}