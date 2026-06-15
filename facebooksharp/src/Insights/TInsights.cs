using RestSharp;
using FacebookSharp.Insights.Models.Request;
using FacebookSharp.Insights.Models.Response;

namespace FacebookSharp.Insights;

public class TInsights : IInsights
{
    private readonly IRestClient _client;

    public TInsights(IRestClient client) => _client = client;

    public RestResponse<InsightCollection> GetPageInsights(PageInsightsRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PageId}/insights", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Metric))
            request.AddQueryParameter("metric", requestModel.Metric);
        if (!string.IsNullOrWhiteSpace(requestModel.Period))
            request.AddQueryParameter("period", requestModel.Period);
        return _client.Execute<InsightCollection>(request);
    }

    public RestResponse<InsightCollection> GetPostInsights(PostInsightsRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.PostId}/insights", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Metric))
            request.AddQueryParameter("metric", requestModel.Metric);
        return _client.Execute<InsightCollection>(request);
    }

    public RestResponse<InsightCollection> Get(InsightsRequest requestModel)
    {
        var request = new RestRequest($"/{requestModel.ObjectId}/insights", Method.Get);
        if (!string.IsNullOrWhiteSpace(requestModel.Metric))
            request.AddQueryParameter("metric", requestModel.Metric);
        if (!string.IsNullOrWhiteSpace(requestModel.Period))
            request.AddQueryParameter("period", requestModel.Period);
        return _client.Execute<InsightCollection>(request);
    }
}
