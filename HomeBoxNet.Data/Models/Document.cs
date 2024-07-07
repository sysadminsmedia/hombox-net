using System.ComponentModel.DataAnnotations;
using HomeBoxNet.Data.Models.Partials;
using Microsoft.EntityFrameworkCore;

namespace HomeBoxNet.Data.Models;

[Index(nameof(Path), IsUnique = true)]
public class Document : DateTimeModel
{
    /// <summary>
    /// Id of document
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Title of the file
    /// </summary>
    [StringLength(512)]
    public required string Title { get; set; }
    
    /// <summary>
    /// Path to the file
    /// </summary>
    [StringLength(1024)]
    public required string Path { get; set; }
    
}