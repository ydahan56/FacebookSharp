namespace FacebookSharp.Users.Models.Request;

public class UserGetRequest
{
    public string UserId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,picture,email";
}
