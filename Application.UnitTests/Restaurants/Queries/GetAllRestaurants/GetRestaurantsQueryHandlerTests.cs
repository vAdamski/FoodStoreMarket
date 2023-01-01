using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants;
using FoodStoreMarket.Persistance;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Restaurants.Queries.GetAllRestaurants;

namespace Application.UnitTests.Restaurants.Queries.GetAllRestaurants
{
    [Collection("QueryCollection")]
    public class GetRestaurantsQueryHandlerTests
    {
        private readonly FoodStoreMarketDbContext _context;
        private readonly IMapper _mapper;
        public GetRestaurantsQueryHandlerTests(QueryTestFixtures fixtures)
        {
            _context = fixtures.Context;
            _mapper = fixtures.Mapper;
        }

        [Fact]
        public async Task CanGetAllRestaurnatsRestaurant()
        { 
            var handler = new GetRestaurantsQueryHandler(_context, _mapper);

            var response = await handler.Handle(new GetRestaurantsQuery { }, CancellationToken.None);

            response.ShouldBeOfType<RestaurantsVm>();
            response.Restaurants.FirstOrDefault().Name.ShouldBe("Pizzeria #1");
            response.Restaurants.FirstOrDefault().Description.ShouldBe("Pizzeria na osiedlu");
            response.Restaurants.LastOrDefault().Name.ShouldBe("Pizzeria #2");
            response.Restaurants.LastOrDefault().Description.ShouldBe("Kebab na Widzewie");
        }
    }
}
