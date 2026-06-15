using Newtonsoft.Json;

namespace FacebookSharp.Pages.Models.Response;

public class PagePostCollection
{
    [JsonProperty("data")]
    public List<PagePost> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
