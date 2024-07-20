using HomeBoxNet.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Group = System.Text.RegularExpressions.Group;

namespace HomeBoxNet.Data;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
{
    public DbSet<User> AppUsers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Label> Labels { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemField> ItemFields { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
};
