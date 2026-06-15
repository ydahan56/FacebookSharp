namespace FacebookSharp.Groups.Models.Request;

public class GroupGetRequest
{
    public string GroupId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,description,icon,owner,privacy,updated_time,parent";
}

public class GroupsListRequest
{
    public string UserId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,description,privacy,icon,updated_time";
    public string? Limit { get; set; }
}

public class GroupMembersRequest
{
    public string GroupId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,email";
    public string? Limit { get; set; }
}

public class GroupFeedRequest
{
    public string GroupId { get; set; } = default!;
    public string? Fields { get; set; } = "id,message,created_time,permalink_url,from";
    public string? Limit { get; set; }
}
