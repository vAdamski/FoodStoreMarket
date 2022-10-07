using Application.UnitTests.Common;
using FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace Application.UnitTests.Restaurants.Commands.DeleteRestaurant;

public class DeleteRestaurantHandlerTests : CommandTestBase, IClassFixture<CommandTestFixture>
{
    private readonly DeleteRestaurantCommandHandler _handler;

    public DeleteRestaurantHandlerTests(CommandTestFixture fixture) : base()
    {
        _handler = new DeleteRestaurantCommandHandler(_context);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_RestaurantShouldBeSoftDeleted()
    {
        var restaurantIdToDelete = 1;
        
        var command = new DeleteRestaurantCommand()
        {
            IdRestaurantToDelete = restaurantIdToDelete
        };

        _handler.Handle(command, CancellationToken.None);

        var resultRestaurant =
            await _context.Restaurants.FirstOrDefaultAsync(x => x.Id == restaurantIdToDelete && x.StatusId == 0);
        
        var resultRestaurantSpecification =
            await _context.Restaurants.FirstOrDefaultAsync(x => x.Id == restaurantIdToDelete && x.StatusId == 0);
        
        var result =
            await _context.Restaurants.FirstOrDefaultAsync(x => x.Id == restaurantIdToDelete && x.StatusId == 0);
    }
}