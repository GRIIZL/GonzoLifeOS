using Microsoft.EntityFrameworkCore;
using Gonzo.Api.Models;

namespace Gonzo.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Goal> Goals => Set<Goal>();
    public DbSet<UserProfile> Profiles => Set<UserProfile>();
    public DbSet<LifeLog> Logs => Set<LifeLog>();
}