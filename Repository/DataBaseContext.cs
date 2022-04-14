using Common.interfaces;
using Common.models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class DataBaseContext : DbContext,IDataBaseContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<Windmill> Windmill { get; set; } = null!;
    public DbSet<WeatherReport> WeatherReport { get; set; } = null!;
}