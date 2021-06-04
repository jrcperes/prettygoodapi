using Domain.Weather;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<WeatherForecastEntity> WeatherForecasts { get; set; }
    }
}
