using System.Threading;
using Application.UnitTests.Common;
using FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Shared.Models.Restaurants.Commands.DeleteRestaurant;
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

        var restaurant = _context.Restaurants
                .Where(r => r.Id == restaurantIdToDelete)
                .Include(r => r.Menu)
                .ThenInclude(m => m.Products)
                .ThenInclude(p => p.ProductSpecification)
                .ThenInclude(ps => ps.ProductSizeSpecifications)
                .ThenInclude(pss => pss.Size)
                .Include(r => r.Menu)
                .ThenInclude(m => m.Ingredients)
                .Include(r => r.Menu)
                .ThenInclude(m => m.ProductTypes)
                .Include(r => r.RestaurantSpecification)
                .ThenInclude(rs => rs.OpeningClosingSpecification)
                .ThenInclude(ocs => ocs.OpeningClosingHours)
                .Include(r => r.RestaurantSpecification)
                .ThenInclude(rs => rs.Employees)
                .ThenInclude(e => e.WorkingHours)
                .FirstOrDefault();

        restaurant.ShouldNotBeNull();

        //Restaurant Status check
        restaurant.StatusId.ShouldBe(0);

        //Menu Ststus check
        restaurant.Menu.StatusId.ShouldBe(0);

        restaurant.Menu.Products.ForEach(p => p.StatusId.ShouldBe(0));

        restaurant.Menu.Products.ForEach(p =>
        {
            p.ProductSpecification.StatusId.ShouldBe(0);
        });

        restaurant.Menu.Ingredients.ForEach(i => i.StatusId.ShouldBe(0));

        restaurant.Menu.ProductTypes.ForEach(pt => pt.StatusId.ShouldBe(0));

        restaurant.Menu.Sizes.ForEach(s => s.StatusId.ShouldBe(0));

        restaurant.Menu.Sizes.ForEach(s =>
        {
            s.ProductSizeSpecifications.ForEach(pss => pss.StatusId.ShouldBe(0));
        });
    }
}