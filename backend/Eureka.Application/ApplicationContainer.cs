using Eureka.Application.Interface;
using Eureka.Application.Service;
using Eureka.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Eureka.Application
{
    public static class ApplicationContainer
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            // Service
            services.AddScoped<ICrudService, CrudService>();

            return services;
        }
    }
}