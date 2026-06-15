namespace FacebookSharp.Places.Models.Request;

public class PlaceRequest
{
    public string PlaceId { get; set; } = default!;
    public string? Fields { get; set; } = "id,name,category,location,about,website";
}

public class PlacesSearchRequest
{
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Distance { get; set; } = "100";
    public string? Fields { get; set; } = "id,name,category,location";
    public string? Limit { get; set; }
}
