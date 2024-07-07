using System.ComponentModel.DataAnnotations;
using HomeBoxNet.Data.Models.Partials;
using Microsoft.EntityFrameworkCore;

namespace HomeBoxNet.Data.Models;

public abstract class Group : DateTimeModel
{
    /// <summary>
    /// Group Id
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Name of the group
    /// </summary>
    [StringLength(255)]
    public required string Name { get; set; }
    
    /// <summary>
    /// ISO 4217 specifies 3-letter codes for currencies that we use
    /// </summary>
    [StringLength(3)]
    public required string Currency { get; set; } = "usd";
    
    /// <summary>
    /// Users that belong to the group
    /// </summary>
    public virtual List<User>? Users { get; set; }
    
    /// <summary>
    /// Labels attached to the group
    /// </summary>
    public virtual List<Label>? Labels { get; set; }
    
    /// <summary>
    /// Documents attached to the group
    /// </summary>
    public virtual List<Document>? Documents { get; set; }
}