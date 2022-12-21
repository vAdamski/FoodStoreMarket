using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoodStoreMarket.Api.Configure;

public static class ServiceConfiguration
{
    public static void AddServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDependencyInjection(configuration);
        
        services.AddCorsConfiguration();
        
        JWTConfiguration.AddJWTConfoguration();
        
        services.AddAuthenticationConfiguration();
        
        services.AddControllers();
        
        services.AddSwaggerConfiguration();
        
        services.AddAuthorizationConfiguration();
    }
}