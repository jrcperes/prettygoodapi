using Application.Interfaces;
using Domain.Weather;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<WeatherForecastEntity> WeatherForecasts { get; set; }
    }
}
