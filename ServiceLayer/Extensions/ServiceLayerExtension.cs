using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services.Abstractions;
using ServiceLayer.Services.Concretes;

namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IDoctorService, DoctorManager>();
            return services;
        }
    }
}
