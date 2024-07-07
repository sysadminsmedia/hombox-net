using System.ComponentModel.DataAnnotations;

namespace HomeBoxNet.Data.Models;

public class ItemField
{
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Type { get; set; }
    public string? TextValue { get; set; }
    public int? NumberValue { get; set; }
    public bool BooleanValue { get; set; } = false;
    public DateTime? TimeValue { get; set; }
    
    public virtual required Item Item { get; set; }
}