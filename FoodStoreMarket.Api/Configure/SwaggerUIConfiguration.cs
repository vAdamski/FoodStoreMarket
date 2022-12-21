using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace FoodStoreMarket.Api.Configure;

public static class SwaggerUIConfiguration
{
    public static void AddSwaggerUIConfiguration(this SwaggerUIOptions options)
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodStoreMarket");
        options.OAuthClientId("swagger");
        options.OAuthClientSecret("secret");
        options.OAuth2RedirectUrl("https://localhost:44376/swagger/oauth2-redirect.html");
        options.OAuthUsePkce();
    }
}