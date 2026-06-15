using Newtonsoft.Json;
using FacebookSharp.Albums.Models.Response;

namespace FacebookSharp.Pages.Models.Response;

public class PagePhoto
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("images")]
    public List<ImageData>? Images { get; set; }
}
