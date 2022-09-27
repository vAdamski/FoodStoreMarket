using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail;
using FoodStoreMarket.Persistance;
using Shouldly;

namespace Application.UnitTests.Restaurants.Queries.GetRestaurantDetail;

[Collection("QueryCollection")]
public class GetRestaurantDetailQueryHandlerTests
{
    private readonly FoodStoreMarketDbContext _context;
    private readonly IMapper _mapper;
    public GetRestaurantDetailQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetRestaurantById()
    {
        var handler = new GetRestaurantDetailQueryHandler(_context, _mapper);
        var restaurantId = 1;

        var result = await handler.Handle(new GetRestaurantDetailQuery { RestaurantId = restaurantId },
            CancellationToken.None);

        result.ShouldBeOfType<RestaurantDetailVm>();
        result.Name.ShouldBe("Pizzeria #1");
    }
}