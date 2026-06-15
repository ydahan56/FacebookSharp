using Newtonsoft.Json;

namespace FacebookSharp.Places.Models.Response;

public class Place
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("category")]
    public string? Category { get; set; }

    [JsonProperty("location")]
    public PlaceLocation? Location { get; set; }

    [JsonProperty("about")]
    public string? About { get; set; }

    [JsonProperty("website")]
    public string? Website { get; set; }

    [JsonProperty("phone")]
    public string? Phone { get; set; }
}

public class PlaceLocation
{
    [JsonProperty("latitude")]
    public double? Latitude { get; set; }

    [JsonProperty("longitude")]
    public double? Longitude { get; set; }

    [JsonProperty("street")]
    public string? Street { get; set; }

    [JsonProperty("city")]
    public string? City { get; set; }

    [JsonProperty("state")]
    public string? State { get; set; }

    [JsonProperty("zip")]
    public string? Zip { get; set; }

    [JsonProperty("country")]
    public string? Country { get; set; }
}

public class PlaceCollection
{
    [JsonProperty("data")]
    public List<Place> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
