using RestSharp;
using FacebookSharp.Events.Models.Request;
using FacebookSharp.Events.Models.Response;

namespace FacebookSharp.Events;

public class TEvents : IEvents
{
    private readonly IRestClient _client;

    public TEvents(IRestClient client) => _client = client;

    public RestResponse<Event> Get(EventGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.EventId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Event>(request);
    }

    public RestResponse<EventCollection> GetFeed(EventFeedGetRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/events", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<EventCollection>(request);
    }
}