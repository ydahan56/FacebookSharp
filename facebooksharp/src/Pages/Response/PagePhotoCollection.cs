using Newtonsoft.Json;

namespace FacebookSharp.Pages.Models.Response;

public class PagePhotoCollection
{
    [JsonProperty("data")]
    public List<PagePhoto> Data { get; set; } = [];
}
