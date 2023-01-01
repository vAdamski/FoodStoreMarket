using FluentValidation;
using FoodStoreMarket.Shared.Models.Ingredients.Commands.DeleteIngredient;

namespace FoodStoreMarket.Application.Ingredients.Commands.DeleteIngredient;

public class DeleteIngredientCommandValidator : AbstractValidator<DeleteIngredientCommand>
{
    public DeleteIngredientCommandValidator()
    {
        RuleFor(x => x.IngredientIdToDelete).NotEmpty().GreaterThan(0);
    }
    
}