using System;
using System.Collections.Generic;
using HomeBoxNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using Group = System.Text.RegularExpressions.Group;

namespace HomeBoxNet.Data;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Label> Labels { get; set; }
};
