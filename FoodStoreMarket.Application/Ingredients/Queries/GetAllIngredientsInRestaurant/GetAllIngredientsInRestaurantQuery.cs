using FoodStoreMarket.Shared.Models.Ingredients.Queries.GetAllIngredientsInRestaurant;
using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetAllIngredientsInRestaurant;

public class GetAllIngredientsInRestaurantQuery : IRequest<IngredientsInRestaurantVm>
{
    public int MenuId { get; set; }
}