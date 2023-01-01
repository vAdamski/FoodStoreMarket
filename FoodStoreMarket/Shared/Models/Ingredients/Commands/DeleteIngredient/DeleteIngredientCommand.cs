using MediatR;

namespace FoodStoreMarket.Shared.Models.Ingredients.Commands.DeleteIngredient;

public class DeleteIngredientCommand : IRequest
{
    public int IngredientIdToDelete { get; set; }
}