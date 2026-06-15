using FacebookSharp.Conversations.Models.Request;
using FacebookSharp.Conversations.Models.Response;
using RestSharp;

namespace FacebookSharp.Conversations;

public interface IConversations
{
    RestResponse<ConversationCollection> GetList(ConversationsListRequest requestModel);
    RestResponse<Conversation> Get(ConversationRequest requestModel);
    RestResponse<ConversationMessageCollection> GetMessages(ConversationMessagesRequest requestModel);
}
