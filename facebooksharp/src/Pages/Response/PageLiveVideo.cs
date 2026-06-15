using Newtonsoft.Json;

namespace FacebookSharp.Pages.Models.Response;

public class PageLiveVideo
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("status")]
    public string? Status { get; set; }

    [JsonProperty("creation_time")]
    public string? CreationTime { get; set; }
}