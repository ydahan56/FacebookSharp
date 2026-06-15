using Newtonsoft.Json;

namespace FacebookSharp.Likes.Models.Response;

public class Like
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("picture")]
    public string? Picture { get; set; }
}

public class LikeCollection
{
    [JsonProperty("data")]
    public List<Like> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }

    [JsonProperty("summary")]
    public LikeSummary? Summary { get; set; }
}

public class LikeSummary
{
    [JsonProperty("total_count")]
    public int? TotalCount { get; set; }

    [JsonProperty("viewer_reaction")]
    public string? ViewerReaction { get; set; }
}
