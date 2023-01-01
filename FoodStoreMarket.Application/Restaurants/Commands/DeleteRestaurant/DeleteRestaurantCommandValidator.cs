using FluentValidation;
using FoodStoreMarket.Shared.Models.Restaurants.Commands.DeleteRestaurant;

namespace FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant;

public class DeleteRestaurantCommandValidator : AbstractValidator<DeleteRestaurantCommand>
{
    public DeleteRestaurantCommandValidator()
    {
        RuleFor(x => x.IdRestaurantToDelete).NotEmpty().GreaterThan(0);
    }
}