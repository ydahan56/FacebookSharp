using Newtonsoft.Json;

namespace FacebookSharp.Pages.Models.Response;

public class PageLiveVideoCollection
{
    [JsonProperty("data")]
    public List<PageLiveVideo> Data { get; set; } = [];
}
