using Newtonsoft.Json;

namespace FacebookSharp.Pages.Models.Response;

public class PageVideo
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("length")]
    public double? Length { get; set; }
}
