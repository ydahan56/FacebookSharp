using Newtonsoft.Json;

namespace FacebookSharp.Users.Models.Response;

public class User
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("picture")]
    public UserPictureData? Picture { get; set; }
}
