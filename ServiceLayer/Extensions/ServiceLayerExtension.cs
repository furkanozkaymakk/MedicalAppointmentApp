using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            return services;
        }
    }
}
