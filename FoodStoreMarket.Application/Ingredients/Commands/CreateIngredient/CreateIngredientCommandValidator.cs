using FluentValidation;
using FoodStoreMarket.Shared.Models.Ingredients.Commands.CreateIngredient;

namespace FoodStoreMarket.Application.Ingredients.Commands.CreateIngredient;

public class CreateIngredientCommandValidator : AbstractValidator<CreateIngredientCommand>
{
    public CreateIngredientCommandValidator()
    {
        RuleFor(x => x.MenuId).GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(20);
    }
}