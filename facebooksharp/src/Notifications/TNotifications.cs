using RestSharp;
using FacebookSharp.Notifications.Models.Request;
using FacebookSharp.Notifications.Models.Response;

namespace FacebookSharp.Notifications;

public class TNotifications : INotifications
{
    private readonly IRestClient _client;

    public TNotifications(IRestClient client) => _client = client;

    public RestResponse<NotificationCollection> GetList(NotificationsListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}/notifications", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<NotificationCollection>(request);
    }

    public RestResponse<Notification> Get(NotificationRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.NotificationId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Notification>(request);
    }
}
