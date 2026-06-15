using Newtonsoft.Json;

namespace FacebookSharp.Friends.Models.Response;

public class Friend
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("picture")]
    public string? Picture { get; set; }
}

public class FriendCollection
{
    [JsonProperty("data")]
    public List<Friend> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
