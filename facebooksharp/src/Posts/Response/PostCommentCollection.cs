using Newtonsoft.Json;

namespace FacebookSharp.Posts.Models.Response;

public class PostCommentCollection
{
    [JsonProperty("data")]
    public List<PostComment> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
