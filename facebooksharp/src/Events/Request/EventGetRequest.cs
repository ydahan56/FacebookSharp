namespace FacebookSharp.Events.Models.Request;

public class EventGetRequest
{
    public string EventId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,start_time,end_time,description,location";
}
