using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant;

public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
{
    public CreateRestaurantCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Description).NotNull().MaximumLength(100);
        RuleFor(x => x.City).NotNull().MaximumLength(25);
        RuleFor(x => x.PostCode).NotNull().MaximumLength(10);
        RuleFor(x => x.Street).NotNull().NotEmpty().MaximumLength(25);
        RuleFor(x => x.HouseNumber).NotNull().NotEmpty().MaximumLength(5);
        RuleFor(x => x.FlatNumber).NotNull().MaximumLength(20);
        RuleFor(x => x.PhoneNumber).NotNull().MinimumLength(7).MaximumLength(10);
        RuleFor(x => x.Email).NotNull().EmailAddress();
    }
}