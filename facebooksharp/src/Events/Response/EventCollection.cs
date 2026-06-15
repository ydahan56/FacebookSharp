using Newtonsoft.Json;

namespace FacebookSharp.Events.Models.Response;

public class EventCollection
{
    [JsonProperty("data")]
    public List<Event> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}