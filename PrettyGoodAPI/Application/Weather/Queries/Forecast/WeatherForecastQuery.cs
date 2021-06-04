using Application.Commons;
using Application.Interfaces;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Weather.Queries.Forecast
{
    public class WeatherForecastQuery : IRequest<WeatherForecastViewModel> { }

    public class WeatherForecastQueryHandler : BaseHandler, IRequestHandler<WeatherForecastQuery, WeatherForecastViewModel>
    {
        public WeatherForecastQueryHandler(IApplicationDbContext context) : base(context) { }

        public async Task<WeatherForecastViewModel> Handle(WeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var weatherForecasts = await context.WeatherForecasts.ToListAsync(cancellationToken);

            return new WeatherForecastViewModel
            {
                WeatherForecasts = weatherForecasts.Adapt<List<WeatherForecastDto>>()
            };
        }
    }
}