using FacebookSharp.Reactions.Models.Request;
using FacebookSharp.Reactions.Models.Response;
using RestSharp;

namespace FacebookSharp.Reactions;

public interface IReactions
{
    RestResponse<ReactionCollection> GetList(ReactionsListRequest requestModel);
    RestResponse<Reaction> Get(ReactionRequest requestModel);
}
