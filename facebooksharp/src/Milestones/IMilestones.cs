using FacebookSharp.Milestones.Models.Request;
using FacebookSharp.Milestones.Models.Response;
using RestSharp;

namespace FacebookSharp.Milestones;

public interface IMilestones
{
    RestResponse<MilestoneCollection> GetList(MilestonesListRequest requestModel);
    RestResponse<Milestone> Get(MilestoneRequest requestModel);
}
