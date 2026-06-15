using Newtonsoft.Json;

namespace FacebookSharp.Users.Models.Response;

public class UserPictureData
{
    [JsonProperty("data")]
    public PictureData? Data { get; set; }
}
