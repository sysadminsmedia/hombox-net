namespace HomeBoxNet.API.Controllers.v1.Requests;

public class CustomField
{
    public bool BooleanValue { get; set; }
    public string? TextValue { get; set; }
    public int? NumberValue { get; set; }
    public required string Type { get; set; }
    public required string Id { get; set; }
    public required string Name { get; set; }
}