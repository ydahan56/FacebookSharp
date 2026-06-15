using FacebookSharp.Groups.Models.Request;
using FacebookSharp.Groups.Models.Response;
using RestSharp;

namespace FacebookSharp.Groups;

public interface IGroups
{
    RestResponse<Group> Get(GroupGetRequest requestModel);
    RestResponse<GroupCollection> GetList(GroupsListRequest requestModel);
    RestResponse<GroupMemberCollection> GetMembers(GroupMembersRequest requestModel);
    RestResponse<GroupCollection> GetFeed(GroupFeedRequest requestModel);
}
