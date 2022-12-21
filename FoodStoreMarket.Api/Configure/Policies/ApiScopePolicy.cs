using Microsoft.AspNetCore.Authorization;

namespace FoodStoreMarket.Api.Configure.Policies
{
    public static class ApiScopePolicy
    {
        public static void ApiScope(this AuthorizationOptions options)
        {
            options.AddPolicy("ApiScope", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "api1");
            });
        }
    }
}
