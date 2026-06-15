using Newtonsoft.Json;

namespace FacebookSharp.Pages.Models.Response;

public class PagePost
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("permalink_url")]
    public string? PermalinkUrl { get; set; }
}
