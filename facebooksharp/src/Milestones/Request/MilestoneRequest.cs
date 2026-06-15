namespace FacebookSharp.Milestones.Models.Request;

public class MilestonesListRequest
{
    public string PageId { get; set; } = default!;
    public string? Fields { get; set; } = "id,title,description,created_time,from";
    public string? Limit { get; set; }
}

public class MilestoneRequest
{
    public string MilestoneId { get; set; } = default!;
    public string? Fields { get; set; } = "id,title,description,created_time,from";
}
