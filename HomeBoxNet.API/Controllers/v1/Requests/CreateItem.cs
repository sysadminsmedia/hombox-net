namespace HomeBoxNet.API.Controllers.v1.Requests;

public class CreateItem
{
    public string? Description { get; set; }
    public List<string>? LabelIds { get; set; }
    public string? LocationId { get; set; }
    public required string Name { get; set; }
    public string? ParentId { get; set; }
}