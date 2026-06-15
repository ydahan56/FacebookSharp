using Newtonsoft.Json;

namespace FacebookSharp.Milestones.Models.Response;

public class Milestone
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("from")]
    public MilestoneFrom? From { get; set; }
}

public class MilestoneFrom
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}

public class MilestoneCollection
{
    [JsonProperty("data")]
    public List<Milestone> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
