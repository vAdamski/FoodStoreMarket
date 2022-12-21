using FoodStoreMarket.Api.Configure.Policies;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStoreMarket.Api.Configure
{
    public static class AuthorizationConfiguration
    {
        public static void AddAuthorizationConfiguration(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.Admin();
                options.ApiScope();
            });
        }
    }
}
