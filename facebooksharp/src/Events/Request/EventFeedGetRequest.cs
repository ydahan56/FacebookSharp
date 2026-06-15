namespace FacebookSharp.Events.Models.Request;

public class EventFeedGetRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,start_time,end_time,description";
    public string? Limit { get; set; }
}