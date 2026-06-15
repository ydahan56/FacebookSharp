using Newtonsoft.Json;

namespace FacebookSharp.Insights.Models.Response;

public class InsightData
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("period")]
    public string? Period { get; set; }

    [JsonProperty("values")]
    public List<InsightValue>? Values { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }
}

public class InsightValue
{
    [JsonProperty("value")]
    public object? Value { get; set; }

    [JsonProperty("end_time")]
    public string? EndTime { get; set; }
}

public class InsightCollection
{
    [JsonProperty("data")]
    public List<InsightData> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}

public class Insight
{
    [JsonProperty("metric")]
    public string? Metric { get; set; }

    [JsonProperty("value")]
    public object? Value { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }
}
