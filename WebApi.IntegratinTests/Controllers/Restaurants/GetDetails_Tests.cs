using FoodStoreMarket;
using FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail;
using FoodStoreMarket.Api.Controllers;
using WebApi.IntegratinTests.Common;
using Xunit;
using Shouldly;

namespace WebApi.IntegratinTests.Controllers.Restaurants
{
    public class GetDetails_Tests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public GetDetails_Tests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GivenRestaurantId_ReturnDirectorDetails()
        {
            var client = _factory.GetAuthenticatedClientAsync();

            string id = "1";
            var response = await client.GetById($"/api/restaurants/{id}");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<RestaurantDetailVm>(response);
            vm.ShouldNotBeNull();
        }
    }
}
