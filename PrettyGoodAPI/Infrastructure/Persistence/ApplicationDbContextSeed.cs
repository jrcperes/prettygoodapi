using AutoFixture;
using Domain.Weather;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedWeatherForecasts(ApplicationDbContext context)
        {
            Fixture fixture = new Fixture();

            if (!context.WeatherForecasts.Any())
            {
                for (int i = 0; i < 5; i++)
                {
                    context.WeatherForecasts.Add(fixture.Create<WeatherForecastEntity>());
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
