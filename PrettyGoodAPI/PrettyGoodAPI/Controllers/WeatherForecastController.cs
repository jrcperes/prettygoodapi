using Application.Weather.Queries.Forecast;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class WeatherForecastController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<WeatherForecastViewModel>> Get()
        {
            return await Mediator.Send(new WeatherForecastQuery());
        }
    }
}

