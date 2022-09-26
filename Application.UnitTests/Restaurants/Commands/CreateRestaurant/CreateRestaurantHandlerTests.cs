using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace Application.UnitTests.Restaurants.Commands.CreateRestaurant;

public class CreateRestaurantHandlerTests : CommandTestBase
{
    private readonly CreateRestaurantCommandHandler _handler;

    public CreateRestaurantHandlerTests() : base()
    {
        _handler = new CreateRestaurantCommandHandler(_context, _mapper);
        
        
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertRestaurant()
    {
        var command = new CreateRestaurantCommand()
        {
            Name = "Kebsik",
            Description = "Kebsik w Łodzi",
            City = "Lodz",
            PostCode = "94-001",
            Street = "Łódzka",
            HouseNumber = "1",
            FlatNumber = "",
            PhoneNumber = "123123123",
            Email = "kebsik@test.com"
        };

        var result = await _handler.Handle(command, CancellationToken.None);

        var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);
        
        restaurant.ShouldBeNull();
    }
}