using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using HomeBoxNet.Data.Models.Partials;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HomeBoxNet.Data.Models;

[Index(nameof(Email), IsUnique = true)]
public abstract class User : IdentityUser<Guid>
{
    /// <summary>
    /// Sets if the user is a superuser
    /// </summary>
    public required bool SuperUser { get; set; } = false;
    
    /// <summary>
    /// Groups user is a part of
    /// </summary>
    public virtual List<Group>? Groups { get; set; }
}