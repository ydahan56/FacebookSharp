namespace FacebookSharp.Authentication;

public class AuthException : Exception
{
    public string? ResponseContent { get; }

    public AuthException(string message) : base(message)
    {
    }

    public AuthException(string message, string? responseContent) : base(message)
    {
        ResponseContent = responseContent;
    }

    public AuthException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
