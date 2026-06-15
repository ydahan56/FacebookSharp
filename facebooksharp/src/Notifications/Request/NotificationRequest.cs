namespace FacebookSharp.Notifications.Models.Request;

public class NotificationsListRequest
{
    public string UserId { get; set; } = default!;
    public string? Fields { get; set; } = "id,title,message,created_time,link,type";
    public string? Limit { get; set; }
}

public class NotificationRequest
{
    public string NotificationId { get; set; } = default!;
    public string? Fields { get; set; } = "id,title,message,created_time,link,type";
}
