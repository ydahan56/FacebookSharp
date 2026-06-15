using Newtonsoft.Json;

namespace FacebookSharp.Pages.Models.Response;

public class PageVideoCollection
{
    [JsonProperty("data")]
    public List<PageVideo> Data { get; set; } = [];
}
