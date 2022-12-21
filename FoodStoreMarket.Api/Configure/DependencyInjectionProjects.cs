using FoodStoreMarket.Application;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Infrastructure;
using FoodStoreMarket.Persistance;
using FoodStoreMarket.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FoodStoreMarket.Api.Configure
{
    public static class DependencyInjectionProjects
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistance(configuration);
            services.AddInfrastructure(configuration);
            services.AddApplication();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(ICurrentUserService), typeof(CurrnetUserService));
        }
    }
}
