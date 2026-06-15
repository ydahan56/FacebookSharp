using RestSharp;
using FacebookSharp.Users;
using FacebookSharp.Pages;
using FacebookSharp.Posts;
using FacebookSharp.Comments;
using FacebookSharp.Photos;
using FacebookSharp.Albums;
using FacebookSharp.Videos;
using FacebookSharp.Events;
using FacebookSharp.Authentication;

namespace FacebookSharp;

public class FacebookClient
{
    public IUsers Users { get; }
    public IPages Pages { get; }
    public IPosts Posts { get; }
    public IComments Comments { get; }
    public IPhotos Photos { get; }
    public IAlbums Albums { get; }
    public IVideos Videos { get; }
    public IEvents Events { get; }

    private readonly IRestClient _client;
    private readonly string _accessToken;

    public FacebookClient(string accessToken, string apiVersion = "v25.0")
    {
        _accessToken = accessToken;
        _client = new RestClient(new RestClientOptions($"https://graph.facebook.com/{apiVersion}"));
        _client.AddDefaultParameter("access_token", accessToken, ParameterType.QueryString);

        Users = new TUsers(_client);
        Pages = new TPages(_client);
        Posts = new TPosts(_client);
        Comments = new TComments(_client);
        Photos = new TPhotos(_client);
        Albums = new TAlbums(_client);
        Videos = new TVideos(_client);
        Events = new TEvents(_client);
    }

    public FacebookAuth CreateAuth(string appId, string appSecret, string redirectUri)
        => new FacebookAuth(appId, appSecret, redirectUri);
}