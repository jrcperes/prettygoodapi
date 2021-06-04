using Application.Interfaces;

namespace Application.Commons
{
    public class BaseHandler
    {
        protected readonly IApplicationDbContext context;

        protected BaseHandler(IApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
