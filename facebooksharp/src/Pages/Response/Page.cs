using Newtonsoft.Json;
using FacebookSharp.Users.Models.Response;

namespace FacebookSharp.Pages.Models.Response;

public class Page
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("about")]
    public string? About { get; set; }

    [JsonProperty("picture")]
    public PictureData? Picture { get; set; }

    [JsonProperty("link")]
    public string? Link { get; set; }

    [JsonProperty("followers_count")]
    public int? FollowersCount { get; set; }
}
