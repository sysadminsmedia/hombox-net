using HomeBoxNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using Group = System.Text.RegularExpressions.Group;

namespace HomeBoxNet.Data;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Label> Labels { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemField> ItemFields { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
};
