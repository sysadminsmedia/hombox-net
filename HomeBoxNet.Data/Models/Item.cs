using System.ComponentModel.DataAnnotations;
using HomeBoxNet.Data.Models.Enums;
using HomeBoxNet.Data.Models.Partials;
using Microsoft.EntityFrameworkCore;

namespace HomeBoxNet.Data.Models;

[Index(nameof(Archived)), Index(nameof(AssetId)), Index(nameof(Manufacturer)), Index(nameof(ModelNumber)), Index(nameof(Name)), Index(nameof(SerialNumber))]
public abstract class Item : DateTimeModel
{
    /// <summary>
    /// Unique Id for the item
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Name for the asset
    /// </summary>
    [StringLength(255)]
    public required string Name { get; set; }
    
    /// <summary>
    /// Description for the item
    /// </summary>
    [StringLength(1024)]
    public string? Description { get; set; }
    
    /// <summary>
    /// The type of item (Asset or Location)
    /// </summary>
    public required ItemType Type { get; set; } = ItemType.Asset;
    
    /// <summary>
    /// Import reference when imported
    /// </summary>
    [StringLength(64)]
    public string? ImportRef { get; set; }
    
    /// <summary>
    /// Notes for item
    /// </summary>
    [StringLength(1024)]
    public string? Notes { get; set; }
    
    /// <summary>
    /// Quantity of items
    /// </summary>
    public int Quantity { get; set; } = 1;

    /// <summary>
    /// Is the item insured
    /// </summary>
    public bool Insured { get; set; } = false;

    /// <summary>
    /// Is the item archived
    /// </summary>
    public bool Archived { get; set; } = false;
    
    /// <summary>
    /// The asset ID for the item
    /// </summary>
    public int AssetId { get; set; } = 0;
    
    /// <summary>
    /// Serial number for the asset
    /// </summary>
    [StringLength(512)]
    public string? SerialNumber { get; set; }
    
    /// <summary>
    /// Model number for the asset
    /// </summary>
    [StringLength(512)]
    public string? ModelNumber { get; set; }
    
    /// <summary>
    /// Manufacturer of the asset
    /// </summary>
    [StringLength(512)]
    public string? Manufacturer { get; set; }
    
    /// <summary>
    /// Does the item have a lifetime warranty
    /// </summary>
    public bool LifetimeWarranty { get; set; }
    
    /// <summary>
    /// When does the warranty expire
    /// </summary>
    public DateTime? WarrantyExpires { get; set; }
    
    /// <summary>
    /// Details of the warranty
    /// </summary>
    [StringLength(1024)]
    public string? WarrantyDetails { get; set; }
    
    /// <summary>
    /// When an item was purchased
    /// </summary>
    public DateTime? PurchaseTime { get; set; }
    
    /// <summary>
    /// Who/what the item was purchased from
    /// </summary>
    [StringLength(512)]
    public string? PurchaseFrom { get; set; }
    
    /// <summary>
    /// Price of the item at purchase
    /// </summary>
    public int? PurchasePrice { get; set; }
    
    /// <summary>
    /// When an item was sold
    /// </summary>
    public DateTime? SoldTime { get; set; }
    
    /// <summary>
    /// Who/what an item was sold to
    /// </summary>
    [StringLength(512)]
    public string? SoldTo { get; set; }
    
    /// <summary>
    /// Price an item was sold at
    /// </summary>
    public int? SoldPrice { get; set; }
    
    /// <summary>
    /// Any notes about a sale
    /// </summary>
    [StringLength(1024)]
    public string? SoldNotes { get; set; }
    
    public virtual required Group Group { get; set; }
    public virtual List<Item>? Items { get; set; }
    public virtual required Item LocationItem { get; set; }

}