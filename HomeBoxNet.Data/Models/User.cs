using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HomeBoxNet.Data.Models.Partials;
using Microsoft.EntityFrameworkCore;

namespace HomeBoxNet.Data.Models;

[Index(nameof(Email), IsUnique = true)]
public abstract class User : DateTimeModel
{
    /// <summary>
    /// Guid Id for User
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Username
    /// </summary>
    [StringLength(255)]
    public required string Name { get; set; }
    
    /// <summary>
    /// We restrict the email input to an email, and restrict to 254 characters because
    /// RFC 2821 places a 256-octet/character limit on the forward-path, including the <> brackets
    /// </summary>
    [EmailAddress, StringLength(254)]
    public required string Email { get; set; }
    
    /// <summary>
    /// While 60 is the max length of bcrypt, we use a max 250 length, we should replace bcrypt
    /// in the future with Argon2id or scrypt when we get a chance
    /// </summary>
    [StringLength(250), JsonIgnore]
    public required string Password { get; set; }
    
    /// <summary>
    /// Sets if the user is a superuser
    /// </summary>
    public required bool SuperUser { get; set; } = false;
    
    /// <summary>
    /// User Role
    /// </summary>
    [StringLength(50)]
    public required string Role { get; set; } = "user";
    
    /// <summary>
    /// When was the user activated
    /// </summary>
    public DateTime ActivatedAt { get; set; }
    
    /// <summary>
    /// Groups user is a part of
    /// </summary>
    public virtual List<Group>? Groups { get; set; }

}