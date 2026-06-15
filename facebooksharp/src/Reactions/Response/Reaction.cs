using Newtonsoft.Json;

namespace FacebookSharp.Reactions.Models.Response;

public class Reaction
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("picture")]
    public string? Picture { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }
}

public class ReactionCollection
{
    [JsonProperty("data")]
    public List<Reaction> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }

    [JsonProperty("summary")]
    public ReactionSummary? Summary { get; set; }
}

public class ReactionSummary
{
    [JsonProperty("total_count")]
    public int? TotalCount { get; set; }

    [JsonProperty("viewer_reaction")]
    public string? ViewerReaction { get; set; }

    [JsonProperty("reaction_count")]
    public Dictionary<string, int>? ReactionCount { get; set; }
}
