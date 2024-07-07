using System.ComponentModel.DataAnnotations;
using HomeBoxNet.Data.Models.Partials;

namespace HomeBoxNet.Data.Models;

public class Label : DateTimeModel
{
    /// <summary>
    /// Unique GUID ID for the label
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Name of the label, restricted to 150 max length
    /// </summary>
    [StringLength(150)]
    public required string Name { get; set; }

    /// <summary>
    /// Description of label, restricted to 512 max length
    /// </summary>
    [StringLength(512)]
    public string? Description { get; set; }

    /// <summary>
    /// How much red (out of 255) for color
    /// </summary>
    [MaxLength(3)]
    public UInt16? ColorRed { get; set; }

    /// <summary>
    /// How much blue (out of 255) for color
    /// </summary>
    [MaxLength(3)]
    public UInt16? ColorBlue { get; set; }

    /// <summary>
    /// How much gree (out of 255) for color
    /// </summary>
    [MaxLength(3)]
    public UInt16? ColorGreen { get; set; }

    /// <summary>
    /// Should we invert the black text of a label to white?
    /// </summary>
    public bool ColorInvertText { get; set; } = false;

    /// <summary>
    /// Group that the label belongs to
    /// </summary>
    public virtual required Group Group { get; set; }
}