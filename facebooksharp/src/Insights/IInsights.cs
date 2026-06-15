using FacebookSharp.Insights.Models.Request;
using FacebookSharp.Insights.Models.Response;
using RestSharp;

namespace FacebookSharp.Insights;

public interface IInsights
{
    RestResponse<InsightCollection> GetPageInsights(PageInsightsRequest requestModel);
    RestResponse<InsightCollection> GetPostInsights(PostInsightsRequest requestModel);
    RestResponse<InsightCollection> Get(InsightsRequest requestModel);
}
