using Microsoft.EntityFrameworkCore;

namespace IMeFeszt.Database;

public class AppDbContext : DbContext
{
    public DbSet<Donater> Donaters { get; set; }
    
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}