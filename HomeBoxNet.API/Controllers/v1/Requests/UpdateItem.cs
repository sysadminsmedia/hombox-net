namespace HomeBoxNet.API.Controllers.v1.Requests;

public class UpdateItem
{
    public bool Archived { get; set; }
    public string? AssetId { get; set; }
    public string? Description { get; set; }
    public List<CustomField>? Fields { get; set; }
    public string? Id { get; set; }
    public bool Insured { get; set; }
    public List<string>? LabelIds { get; set; }
    public bool LifetimeWarranty { get; set; }
    public required string LocationId { get; set; }
    public string? Manufacturer { get; set; }
    public string? ModelNumber { get; set; }
    public string? Name { get; set; }
    public string? Notes { get; set; }
    public string? ParentId { get; set; }
    public string? PurchaseFrom { get; set; }
    public string? PurchasePrice { get; set; }
    public string? PurchaseTime { get; set; }
    public int Quantity { get; set; }
    public string? SerialNumber { get; set; }
    public string? SoldNotes { get; set; }
    public string? SoldPrice { get; set; }
    public string? SoldTime { get; set; }
    public string? SoldTo { get; set; }
    public string? WarrantyDetails { get; set; }
    public string? WarrantyExpires { get; set; }
}