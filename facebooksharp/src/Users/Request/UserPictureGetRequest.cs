namespace FacebookSharp.Users.Models.Request;

public class UserPictureGetRequest
{
    public string UserId { get; set; } = default!;
    public string? Width { get; set; }
    public string? Height { get; set; }
}