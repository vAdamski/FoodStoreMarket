using FluentValidation;

namespace FoodStoreMarket.Application.Ingredients.Commands.CreateIngredient;

public class CreateIngredientCommandValidator : AbstractValidator<CreateIngredientCommand>
{
    public CreateIngredientCommandValidator()
    {
        RuleFor(x => x.MenuId).GreaterThan(0);
        RuleFor(x => x.Name).MinimumLength(2).MaximumLength(20);
    }
}