using Newtonsoft.Json;
using FacebookSharp.Posts.Models.Response;

namespace FacebookSharp.Comments.Models.Response;

public class Comment
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }

    [JsonProperty("from")]
    public PostFrom? From { get; set; }
}

public class CommentCollection
{
    [JsonProperty("data")]
    public List<Comment> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}

public class CreateCommentResponse
{
    [JsonProperty("id")]
    public string? Id { get; set; }
}