using FluentValidation;

namespace FoodStoreMarket.Application.Ingredients.Commands.DeleteIngredient;

public class DeleteIngredientCommandValidator : AbstractValidator<DeleteIngredientCommand>
{
    public DeleteIngredientCommandValidator()
    {
        RuleFor(x => x.IngredientIdToDelete).NotEmpty().GreaterThan(0);
    }
    
}