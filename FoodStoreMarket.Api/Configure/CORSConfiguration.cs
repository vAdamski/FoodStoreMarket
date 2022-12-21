using Microsoft.Extensions.DependencyInjection;

namespace FoodStoreMarket.Api.Configure
{
    public static class CORSConfiguration
    {
        public static void AddCorsConfiguration(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CORS", policy => policy.WithOrigins(new string[]
                {
                    "https://localhost:5000",
                    "https://localhost:44376",
                    "https://localhost:4449"
                }));
            });
        }
    }
}
