using FacebookSharp.Events.Models.Request;
using FacebookSharp.Events.Models.Response;
using RestSharp;

namespace FacebookSharp.Events;

public interface IEvents
{
    RestResponse<Event> Get(EventGetRequest requestModel);
    RestResponse<EventCollection> GetFeed(EventFeedGetRequest requestModel);
}