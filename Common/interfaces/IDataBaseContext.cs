using Common.models;
using Microsoft.EntityFrameworkCore;

namespace Common.interfaces;

public interface IDataBaseContext : IDbContext, IDisposable
{
    public DbSet<Windmill> Windmill { get; set; }
    public DbSet<WeatherReport> WeatherReport { get; set; }
}