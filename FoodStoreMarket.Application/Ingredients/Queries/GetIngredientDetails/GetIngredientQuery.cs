using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetIngredientDetails;

public class GetIngredientQuery : IRequest<IngredientVm>
{
    public int IngredientId { get; set; }
}