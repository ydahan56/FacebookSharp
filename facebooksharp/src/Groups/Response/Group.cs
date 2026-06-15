using Newtonsoft.Json;

namespace FacebookSharp.Groups.Models.Response;

public class Group
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("icon")]
    public string? Icon { get; set; }

    [JsonProperty("privacy")]
    public string? Privacy { get; set; }

    [JsonProperty("updated_time")]
    public string? UpdatedTime { get; set; }

    [JsonProperty("owner")]
    public GroupOwner? Owner { get; set; }

    [JsonProperty("parent")]
    public GroupParent? Parent { get; set; }
}

public class GroupOwner
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}

public class GroupParent
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}

public class GroupCollection
{
    [JsonProperty("data")]
    public List<Group> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}

public class GroupMember
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }
}

public class GroupMemberCollection
{
    [JsonProperty("data")]
    public List<GroupMember> Data { get; set; } = [];

    [JsonProperty("paging")]
    public Paging? Paging { get; set; }
}
