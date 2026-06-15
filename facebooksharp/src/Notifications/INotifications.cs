using FacebookSharp.Notifications.Models.Request;
using FacebookSharp.Notifications.Models.Response;
using RestSharp;

namespace FacebookSharp.Notifications;

public interface INotifications
{
    RestResponse<NotificationCollection> GetList(NotificationsListRequest requestModel);
    RestResponse<Notification> Get(NotificationRequest requestModel);
}
