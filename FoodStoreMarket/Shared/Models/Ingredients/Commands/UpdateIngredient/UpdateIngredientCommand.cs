using MediatR;

namespace FoodStoreMarket.Shared.Models.Ingredients.Commands.UpdateIngredient;

public class UpdateIngredientCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }
}