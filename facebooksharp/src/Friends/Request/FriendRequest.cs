namespace FacebookSharp.Friends.Models.Request;

public class FriendsListRequest
{
    public string UserId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture,email";
    public string? Limit { get; set; }
}

public class FriendRequest
{
    public string FriendId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,email,picture";
}
