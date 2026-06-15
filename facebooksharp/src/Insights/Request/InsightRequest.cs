namespace FacebookSharp.Insights.Models.Request;

public class PageInsightsRequest
{
    public string PageId { get; set; } = default!;
    public string? Metric { get; set; } = "page_fans,page_impressions,page_engaged_users";
    public string? Period { get; set; } = "day";
}

public class PostInsightsRequest
{
    public string PostId { get; set; } = default!;
    public string? Metric { get; set; } = "post_impressions,post_engaged_users,post_clicks";
}

public class InsightsRequest
{
    public string ObjectId { get; set; } = default!;
    public string? Metric { get; set; }
    public string? Period { get; set; } = "day";
}
