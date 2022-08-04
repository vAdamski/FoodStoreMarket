using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant;

public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
{
    public CreateRestaurantCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Description).MaximumLength(100);
        RuleFor(x => x.City).NotNull().MaximumLength(25);
        RuleFor(x => x.PostCode).NotNull().MaximumLength(10);
        RuleFor(x => x.Street).NotEmpty().MaximumLength(25);
        RuleFor(x => x.HouseNumber).NotEmpty().MinimumLength(1);
        RuleFor(x => x.FlatNumber).MaximumLength(20);
        RuleFor(x => x.PhoneNumber).MinimumLength(7).MaximumLength(10);
        RuleFor(x => x.Email).NotNull().EmailAddress();
    }
}