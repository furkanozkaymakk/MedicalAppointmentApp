using DataAccessLayer.Repositories.Abstractions;
using DataAccessLayer.Repositories.Concretes;
using DataAccessLayer.UnitOfWorks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Extensions
{
    public static class DataAccessLayerExtension
    {
        public static IServiceCollection LoadDataAccessLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            //TODO: Scope bırakılacak yer. ProgramCs şişmesin
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));//IRepository Repository^e bağlandığı için ben her IRepository istek attığımda  Repository nesnesini getir demiş olduk
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
