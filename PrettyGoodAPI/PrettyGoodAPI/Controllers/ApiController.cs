using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
        private ISender mediator;

        protected ISender Mediator => mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
