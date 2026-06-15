using Newtonsoft.Json;

namespace FacebookSharp.Events.Models.Response;

public class Event
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("start_time")]
    public string? StartTime { get; set; }

    [JsonProperty("end_time")]
    public string? EndTime { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("location")]
    public string? Location { get; set; }
}
