using System.ComponentModel.DataAnnotations;
using HomeBoxNet.Data.Models.Partials;

namespace HomeBoxNet.Data.Models;

public class Attachment : DateTimeModel
{
    /// <summary>
    /// Unique Id for attachment
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Type of attachment
    /// </summary>
    public required string Type { get; set; }
    
    /// <summary>
    /// Is this the primary attachment for the item
    /// </summary>
    public bool Primary { get; set; } = false;
    
    /// <summary>
    /// The document that is tied to the attachment
    /// </summary>
    public virtual required Document Document { get; set; }
    
    /// <summary>
    /// The Item the attachment is tied to
    /// </summary>
    public virtual required Item Item { get; set; }
}