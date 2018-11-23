using Bll.Interfaces;
using BLL.Implemented;
using Microsoft.Extensions.DependencyInjection;

namespace Middleware
{
    public static class ServiceDependencyInjectionMiddleware
    {
        public static void RegisterServices(this IServiceCollection service)
        {
            service.AddScoped<IProductService, ProductService>();
        }
    }
}
