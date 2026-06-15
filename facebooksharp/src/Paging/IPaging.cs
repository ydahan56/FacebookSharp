using Newtonsoft.Json;

namespace FacebookSharp;

public class Paging
{
    [JsonProperty("cursors")]
    public Cursors? Cursors { get; set; }

    [JsonProperty("next")]
    public string? Next { get; set; }

    [JsonProperty("previous")]
    public string? Previous { get; set; }
}

public class Cursors
{
    [JsonProperty("before")]
    public string? Before { get; set; }

    [JsonProperty("after")]
    public string? After { get; set; }
}