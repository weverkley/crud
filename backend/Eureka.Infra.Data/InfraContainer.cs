using Eureka.Domain.Repository;
using Eureka.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Eureka.Infra.Data
{
    public static class InfraContainer
    {
        public static IServiceCollection RegisterInfraServices(this IServiceCollection services)
        {
            // Repository
            services.AddScoped<ICrudRepository, CrudRepository>();

            return services;
        }
    }
}