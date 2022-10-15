using System.Reflection;
using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail;
using FoodStoreMarket.Common;
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
        var restaurantId = 1;
        var expectedRestaurant = new RestaurantDetailVm
        {
            Name = "Pizzeria #1",
            Description = "Pizzeria na osiedlu",
            City = "Lodz",
            PostCode = "94-000",
            Street = "al.Politechniki",
            HouseNumber = "1",
            PhoneNumber = "123456789",
            Email = "PIZZERIA@GMAIL.COM"
        };

        var handler = new GetRestaurantDetailQueryHandler(_context, _mapper);

        var result = await handler.Handle(new GetRestaurantDetailQuery { RestaurantId = restaurantId },
            CancellationToken.None);

        result.ShouldBeOfType<RestaurantDetailVm>();
        foreach (PropertyInfo propertyInfo in result.GetType().GetProperties())
        {
            var resultPropertyValue = result.GetType().GetProperty(propertyInfo.Name)?.GetValue(result, null);
            var expectedPropertyValue = expectedRestaurant.GetType().GetProperty(propertyInfo.Name)
                ?.GetValue(expectedRestaurant, null);
            
            resultPropertyValue.ShouldBe(expectedPropertyValue);
        }
    }
    
    [Fact]
    public async Task Handle_GivenNotExistedRestaurantId_ShouldReturnNotFound()
    {
        try
        {
            var restaurantId = 2;
    
            var handler = new GetRestaurantDetailQueryHandler(_context, _mapper);
    
            var result = await handler.Handle(new GetRestaurantDetailQuery { RestaurantId = restaurantId },
                CancellationToken.None);
        
            result.ShouldBeNull();
        }
        catch (Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(404);
        }
    }
    
    [Fact]
    public async Task Handle_GivenNegativeId_ShouldReturnBadRequest()
    {
        try
        {
            var restaurantId = -10;
    
            var handler = new GetRestaurantDetailQueryHandler(_context, _mapper);
    
            var result = await handler.Handle(new GetRestaurantDetailQuery { RestaurantId = restaurantId },
                CancellationToken.None);
        
            result.ShouldBeNull();
        }
        catch (Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
        
    }
    
    [Fact]
    public async Task Handle_GivenRestaurantIdIsLowerThenZero_ShouldReturnBadRequest()
    {
        try
        {
            var handler = new GetRestaurantDetailQueryHandler(_context, _mapper);

            var query = new GetRestaurantDetailQuery()
            {
                RestaurantId = -1
            };
            
            var result = await handler.Handle(query,
                CancellationToken.None);
        
            result.ShouldBeNull();
        }
        catch (Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenRestaurantIdIsZero_ShouldReturnBadRequest()
    {
        try
        {
            var handler = new GetRestaurantDetailQueryHandler(_context, _mapper);

            var query = new GetRestaurantDetailQuery()
            {
                RestaurantId = 0
            };
            
            var result = await handler.Handle(query,
                CancellationToken.None);
        
            result.ShouldBeNull();
        }
        catch (Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenRestaurantIdWithNotExistingEntity_NotFound()
    {
        try
        {
            var handler = new GetRestaurantDetailQueryHandler(_context, _mapper);

            var query = new GetRestaurantDetailQuery()
            {
                RestaurantId = 9
            };
            
            var result = await handler.Handle(query,
                CancellationToken.None);
        
            result.ShouldBeNull();
        }
        catch (Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(404);
        }
    }
}