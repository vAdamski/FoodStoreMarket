using Microsoft.AspNetCore.Authorization;

namespace FoodStoreMarket.Api.Configure.Policies
{
    public static class AdminPolicy
    {
        public static void Admin(this AuthorizationOptions options)
        {
            options.AddPolicy("admin", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "api1");
                policy.RequireRole("admin");
            });
        }
    }
}
