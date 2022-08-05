using FluentValidation;

namespace FoodStoreMarket.Application.Ingredients.Commands.EditIngredient;

public class EditIngredientCommandValidator : AbstractValidator<EditIngredientCommand>
{
    public EditIngredientCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(20);
    }
}