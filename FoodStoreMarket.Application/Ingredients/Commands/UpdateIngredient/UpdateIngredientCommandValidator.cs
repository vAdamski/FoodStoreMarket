using FluentValidation;

namespace FoodStoreMarket.Application.Ingredients.Commands.UpdateIngredient;

public class UpdateIngredientCommandValidator : AbstractValidator<UpdateIngredientCommand>
{
    public UpdateIngredientCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(20);
    }
}