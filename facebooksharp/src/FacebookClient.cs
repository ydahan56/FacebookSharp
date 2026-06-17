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
using FacebookSharp.Insights;
using FacebookSharp.Groups;
using FacebookSharp.Feed;
using FacebookSharp.Conversations;
using FacebookSharp.Likes;
using FacebookSharp.LiveVideos;
using FacebookSharp.Notifications;
using FacebookSharp.Places;
using FacebookSharp.Friends;
using FacebookSharp.Milestones;
using FacebookSharp.Reactions;
using System;

namespace FacebookSharp;

/// <summary>
/// The main entry point for the Facebook Graph API SDK.
/// </summary>
public class FacebookClient : IDisposable
{
    private readonly IRestClient _client;
    private readonly string _accessToken;

    /// <summary>Access user profiles, friend lists, and permissions.</summary>
    public IUsers Users { get; }

    /// <summary>Access page metadata, settings, and administration.</summary>
    public IPages Pages { get; }

    /// <summary>Manage feed posts, stories, and statuses.</summary>
    public IPosts Posts { get; }

    /// <summary>Manage interactions on posts and photos.</summary>
    public IComments Comments { get; }

    /// <summary>Handle photo uploads and collection browsing.</summary>
    public IPhotos Photos { get; }

    /// <summary>Organize and retrieve photo/video albums.</summary>
    public IAlbums Albums { get; }

    /// <summary>Manage video content and video metadata.</summary>
    public IVideos Videos { get; }

    /// <summary>Manage event creation, discovery, and RSVPs.</summary>
    public IEvents Events { get; }

    /// <summary>Access metrics and analytics for pages, posts, and apps.</summary>
    public IInsights Insights { get; }

    /// <summary>Access Facebook Groups and group-specific content.</summary>
    public IGroups Groups { get; }

    /// <summary>Search for pages, places, and other Graph objects.</summary>
    public IFeed Feed { get; }

    /// <summary>Manage Facebook Applications and app-level settings.</summary>
    public IConversations Conversations { get; }

    /// <summary>Manage Facebook Business Manager accounts and assets.</summary>
    public ILikes Likes { get; }

    /// <summary>Access Instagram Graph API for business and creator accounts.</summary>
    public INotifications Notifications { get; }

    /// <summary>Manage Facebook Ad Accounts and marketing campaigns.</summary>
    public IPlaces Places { get; }

    /// <summary>Manage and inspect application permissions.</summary>
    public IFriends Friends { get; }

    /// <summary>Debug access tokens and inspect API limits.</summary>
    public IMilestones Milestones { get; }

    /// <summary>Manage live stream broadcasts and configurations.</summary>
    public ILiveVideos LiveVideos { get; }

    public IReactions Reactions { get; }

    /// <summary>A shortcut for the "me" user node (the current authenticated user/page).</summary>
    public IUsers Me => Users;

    /// <summary>
    /// Initializes the Facebook SDK with an access token.
    /// </summary>
    /// <param name="accessToken">A valid Facebook Access Token (User, Page, or App token).</param>
    /// <param name="apiVersion">The Graph API version to target (defaults to v25.0).</param>
    public FacebookClient(string accessToken, string apiVersion = "v25.0")
    {
        _accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken), "Access token cannot be null.");

        var options = new RestClientOptions($"https://graph.facebook.com/{apiVersion}");
        _client = new RestClient(options);

        // Global authentication for all subsequent module requests
        _client.AddDefaultQueryParameter("access_token", _accessToken);

        // Initialize all API modules with the shared RestClient
        this.Users = new TUsers(_client);
        this.Pages = new TPages(_client);
        this.Posts = new TPosts(_client);
        this.Comments = new TComments(_client);
        this.Albums = new TAlbums(_client);
        this.Photos = new TPhotos(_client);
        this.Videos = new TVideos(_client);
        this.Events = new TEvents(_client);
        this.Insights = new TInsights(_client);
        this.Groups = new TGroups(_client);
        this.Feed = new TFeed(_client);
        this.Conversations = new TConversations(_client);
        this.Likes = new TLikes(_client);
        this.Notifications = new TNotifications(_client);
        this.Places = new TPlaces(_client);
        this.Friends = new TFriends(_client);
        this.Milestones = new TMilestones(_client);
        this.LiveVideos = new TLiveVideos(_client);
        this.Reactions = new TReactions(_client);
    }

    /// <summary>
    /// Creates an authentication helper for OAuth workflows, such as exchanging codes for tokens.
    /// </summary>
    public FacebookAuth CreateAuth(string appId, string appSecret, string redirectUri)
    {
        return new FacebookAuth(appId, appSecret, redirectUri);
    }

    /// <summary>
    /// Disposes the underlying HTTP client.
    /// </summary>
    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
