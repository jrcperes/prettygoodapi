using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Weather.Queries.Forecast
{
    public class WeatherForecastDto
    {
        public Guid Id { get; init; }

        public DateTime Date { get; init; }

        public int TemperatureC { get; init; }

        public int TemperatureF { get; init; }

        public string Summary { get; init; }
    }
}
