using Dal.Implemented;
using Dal.Implemented.Base;
using Dal.Interfaces;
using Dal.Interfaces.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Middleware
{
    public static class RepositoryDependencyInjectionMiddleware
    {
        public static void RegisterRepositories(this IServiceCollection service)
        {
            service.AddSingleton(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            service.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
