using Microsoft.Extensions.DependencyInjection;
using System.IdentityModel.Tokens.Jwt;

namespace FoodStoreMarket.Api.Configure
{
    public static class JWTConfiguration
    {
        public static void AddJWTConfoguration()
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
        }
    }
}
