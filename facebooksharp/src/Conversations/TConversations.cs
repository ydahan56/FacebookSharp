using RestSharp;
using FacebookSharp.Conversations.Models.Request;
using FacebookSharp.Conversations.Models.Response;

namespace FacebookSharp.Conversations;

public class TConversations : IConversations
{
    private readonly IRestClient _client;

    public TConversations(IRestClient client) => _client = client;

    public RestResponse<ConversationCollection> GetList(ConversationsListRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.UserId}/conversations", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<ConversationCollection>(request);
    }

    public RestResponse<Conversation> Get(ConversationRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ConversationId}", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        return _client.Execute<Conversation>(request);
    }

    public RestResponse<ConversationMessageCollection> GetMessages(ConversationMessagesRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ConversationId}/messages", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Fields))
            request.AddQueryParameter("fields", requestModel.Fields);
        if (!string.IsNullOrWhiteSpace(requestModel.Limit))
            request.AddQueryParameter("limit", requestModel.Limit);
        return _client.Execute<ConversationMessageCollection>(request);
    }
}
