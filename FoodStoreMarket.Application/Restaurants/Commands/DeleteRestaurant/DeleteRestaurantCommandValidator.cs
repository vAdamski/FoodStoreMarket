using FluentValidation;

namespace FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant;

public class DeleteRestaurantCommandValidator : AbstractValidator<DeleteRestaurantCommand>
{
    public DeleteRestaurantCommandValidator()
    {
        RuleFor(x => x.IdRestaurantToDelete).NotEmpty().GreaterThan(0);
    }
}