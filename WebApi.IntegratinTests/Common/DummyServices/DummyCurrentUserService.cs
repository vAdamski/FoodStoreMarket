using FoodStoreMarket.Application.Interfaces;

namespace WebApi.IntegratinTests.Common.DummyServices
{
    public class DummyCurrentUserService : ICurrentUserService
    {
        public string Email { get; set; } = "user@user.pl";
        public bool IsAuthenticated { get; set; } = true;
        public string Role { get; set; } = "user";
    }
}
