using MediatR;

namespace FoodStoreMarket.Shared.Models.Ingredients.Commands.CreateIngredient;

public class CreateIngredientCommand : IRequest<int>
{
    public int MenuId { get; set; }
    public string Name { get; set; }
}