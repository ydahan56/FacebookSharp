# FacebookSharp - Facebook Graph API C# SDK

A modern, simple, and intuitive C# wrapper around Facebook's Graph API that provides easy access to Facebook data including users, pages, posts, comments, photos, albums, videos, and events.

## Features

- 🔐 **Easy Authentication** - Built-in OAuth support for user and app tokens
- 👥 **Users** - Retrieve user profiles and profile pictures
- 📄 **Pages** - Access page information, posts, photos, videos, and live videos
- 📝 **Posts** - Get post details and comments
- 💬 **Comments** - Retrieve, create, and delete comments
- 📸 **Photos** - Access individual photos and photo collections
- 📂 **Albums** - Browse albums and their photos
- 🎥 **Videos** - Get video information and collections
- 🎉 **Events** - Access event details and attendee information

## Installation

Add the NuGet package to your project:

```bash
dotnet add package FacebookSharp
```

Or using Package Manager:

```
Install-Package FacebookSharp
```

## Quick Start

### Basic Usage

```csharp
using FacebookSharp;

// Initialize the Facebook client with your access token
var client = new FacebookClient("YOUR_ACCESS_TOKEN");

// Get user information
var userRequest = new UserGetRequest { UserId = "me" };
var userResponse = client.Users.Get(userRequest);

if (userResponse.IsSuccessful)
{
    var user = userResponse.Data;
    Console.WriteLine($"User: {user.Name}, Email: {user.Email}");
}
```

### Authentication

#### User Authentication

```csharp
// Create authentication helper
var auth = client.CreateAuth("YOUR_APP_ID", "YOUR_APP_SECRET", "YOUR_REDIRECT_URI");

// Get login URL
string loginUrl = auth.BuildLoginUrl("public_profile,user_pages");

// After user authorizes and you get the code:
var authResponse = await auth.ExchangeCodeForUserTokenAsync(code);
var accessToken = authResponse.AccessToken;

// Exchange for long-lived token (valid for 60 days)
var longLivedToken = await auth.ExchangeForLongLivedUserTokenAsync(accessToken);
var longLivedAccessToken = longLivedToken.AccessToken;
```

#### Page Access Token

```csharp
// Get page access token using user token
var pageAccessToken = await auth.GetPageAccessTokenAsync(userToken, pageId);
```

#### App Access Token

```csharp
// Get app-level access token
var appToken = await auth.GetAppAccessTokenAsync();
```

## API Usage Examples

### Users

```csharp
// Get user details
var userRequest = new UserGetRequest 
{ 
    UserId = "me",
    Fields = "id,name,email,picture"
};
var user = client.Users.Get(userRequest);

// Get user profile picture
var pictureRequest = new UserPictureGetRequest 
{ 
    UserId = "me",
    Width = "200",
    Height = "200"
};
var picture = client.Users.GetPicture(pictureRequest);
```

### Pages

```csharp
// Get page information
var pageRequest = new PageGetRequest { PageId = "PAGE_ID" };
var page = client.Pages.Get(pageRequest);

// Get page feed
var feedRequest = new PageFeedGetRequest 
{ 
    PageId = "PAGE_ID",
    Limit = "10"
};
var feed = client.Pages.GetFeed(feedRequest);

// Get page posts
var postsRequest = new PagePostsGetRequest 
{ 
    PageId = "PAGE_ID",
    Limit = "5"
};
var posts = client.Pages.GetPosts(postsRequest);

// Get page photos
var photosRequest = new PagePhotosGetRequest { PageId = "PAGE_ID" };
var photos = client.Pages.GetPhotos(photosRequest);

// Get page videos
var videosRequest = new PageVideosGetRequest { PageId = "PAGE_ID" };
var videos = client.Pages.GetVideos(videosRequest);

// Get page live videos
var liveVideosRequest = new PageLiveVideosGetRequest { PageId = "PAGE_ID" };
var liveVideos = client.Pages.GetLiveVideos(liveVideosRequest);
```

### Posts

```csharp
// Get post details
var postRequest = new PostGetRequest 
{ 
    PostId = "POST_ID",
    Fields = "id,message,created_time,permalink_url"
};
var post = client.Posts.Get(postRequest);

// Get post comments
var commentsRequest = new PostCommentsGetRequest 
{ 
    PostId = "POST_ID",
    Limit = "10"
};
var comments = client.Posts.GetComments(commentsRequest);
```

### Comments

```csharp
// Get comment details
var commentRequest = new CommentGetRequest { CommentId = "COMMENT_ID" };
var comment = client.Comments.Get(commentRequest);

// Get comment replies
var repliesRequest = new CommentRepliesGetRequest 
{ 
    CommentId = "COMMENT_ID",
    Limit = "5"
};
var replies = client.Comments.GetReplies(repliesRequest);

// Create a comment
var createRequest = new CommentCreateRequest 
{ 
    PostId = "POST_ID",
    Message = "This is a comment!"
};
var newComment = client.Comments.Create(createRequest);

// Delete a comment
var deleteRequest = new CommentDeleteRequest { CommentId = "COMMENT_ID" };
client.Comments.Delete(deleteRequest);
```

### Photos

```csharp
// Get photo details
var photoRequest = new PhotoGetRequest 
{ 
    PhotoId = "PHOTO_ID",
    Fields = "id,name,picture,source,created_time"
};
var photo = client.Photos.Get(photoRequest);

// Get all photos from an object
var photosRequest = new PhotosGetRequest 
{ 
    ObjectId = "OBJECT_ID",
    Limit = "20"
};
var photos = client.Photos.GetAll(photosRequest);
```

### Albums

```csharp
// Get album details
var albumRequest = new AlbumGetRequest { AlbumId = "ALBUM_ID" };
var album = client.Albums.Get(albumRequest);

// Get album photos
var photosRequest = new AlbumPhotosGetRequest 
{ 
    AlbumId = "ALBUM_ID",
    Limit = "10"
};
var photos = client.Albums.GetPhotos(photosRequest);

// Get albums feed
var feedRequest = new AlbumFeedGetRequest 
{ 
    ObjectId = "OBJECT_ID",
    Limit = "5"
};
var albums = client.Albums.GetFeed(feedRequest);
```

### Videos

```csharp
// Get video details
var videoRequest = new VideoGetRequest 
{ 
    VideoId = "VIDEO_ID",
    Fields = "id,name,description,created_time"
};
var video = client.Videos.Get(videoRequest);

// Get videos feed
var feedRequest = new VideoFeedGetRequest 
{ 
    ObjectId = "OBJECT_ID",
    Limit = "10"
};
var videos = client.Videos.GetFeed(feedRequest);
```

### Events

```csharp
// Get event details
var eventRequest = new EventGetRequest 
{ 
    EventId = "EVENT_ID",
    Fields = "id,name,description,start_time,end_time"
};
var fbEvent = client.Events.Get(eventRequest);

// Get events feed
var feedRequest = new EventFeedGetRequest 
{ 
    ObjectId = "OBJECT_ID",
    Limit = "10"
};
var events = client.Events.GetFeed(feedRequest);
```

## Project Structure

```
src/
├── FcebookClient.cs           # Main client class
├── Albums/                    # Album operations
├── Comments/                  # Comment operations
├── Events/                    # Event operations
├── Pages/                     # Page operations
├── Posts/                     # Post operations
├── Photos/                    # Photo operations
├── Users/                     # User operations
├── Videos/                    # Video operations
├── Authentication/            # OAuth and authentication
│   ├── FacebookAuth.cs        # OAuth handling
│   ├── AuthException.cs       # Auth exceptions
│   └── FacebookAuthResponse.cs # Auth response models
└── Paging/                    # Pagination support
```

## Dependencies

- **RestSharp 114.0.1** - HTTP client for making API requests
- **Newtonsoft.Json 13.0.5** - JSON serialization/deserialization
- **SimpleInjector 5.5.2** - Dependency injection (optional)
- **.NET 10.0+** - Target framework

## Error Handling

The SDK provides error handling through `AuthException` for authentication issues and response status checking:

```csharp
try
{
    var response = client.Users.Get(userRequest);
    
    if (!response.IsSuccessful)
    {
        Console.WriteLine($"Error: {response.StatusCode}");
        Console.WriteLine($"Message: {response.ErrorMessage}");
    }
}
catch (AuthException ex)
{
    Console.WriteLine($"Authentication error: {ex.Message}");
    if (!string.IsNullOrEmpty(ex.ResponseContent))
    {
        Console.WriteLine($"Details: {ex.ResponseContent}");
    }
}
```

## Configuration

### API Version

You can specify the Facebook Graph API version when creating the client:

```csharp
var client = new FacebookClient(accessToken, apiVersion: "v20.0");
```

Default API version is `v25.0`.

## Rate Limiting

Facebook's API has rate limits. The SDK will include rate limit information in the response headers. Monitor your API usage and implement exponential backoff for retries.

## Best Practices

1. **Use specific fields** - Request only the fields you need to reduce payload size
2. **Implement error handling** - Always check `IsSuccessful` property
3. **Cache tokens** - Reuse access tokens when possible
4. **Use pagination** - For large datasets, use the `Limit` parameter and pagination cursors
5. **Handle async operations** - Use async/await for auth operations
6. **Set appropriate scopes** - Only request necessary permissions

## Pagination

Use the `Paging` property to handle paginated results:

```csharp
var feedRequest = new PageFeedGetRequest { PageId = "PAGE_ID" };
var feed = client.Pages.GetFeed(feedRequest);

if (feed.Data?.Paging?.Next != null)
{
    // Get next page using the cursor
    var nextUrl = feed.Data.Paging.Next;
}
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Support

For issues, feature requests, or questions, please open an issue on GitHub.

## Disclaimer

This SDK is not officially affiliated with Facebook/Meta. Use it at your own discretion and ensure compliance with Facebook's Terms of Service and API policies.

## Resources

- [Facebook Graph API Documentation](https://developers.facebook.com/docs/graph-api)
- [Facebook Developer Platform](https://developers.facebook.com)
- [API Explorer](https://developers.facebook.com/tools/explorer)
