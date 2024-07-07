using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HomeBoxNet.Data.Models;

public abstract class Group
{
    [Key]
    public Guid Id { get; set; }
    [StringLength(255)]
    public required string Name { get; set; }
    // ISO 4217 specifies 3-letter codes for currencies that we use
    [StringLength(3)]
    public required string Currency { get; set; } = "usd";
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public virtual List<User>? Users { get; set; }
}