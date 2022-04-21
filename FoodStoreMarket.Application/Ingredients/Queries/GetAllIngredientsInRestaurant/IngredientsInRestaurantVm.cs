using System.Collections.Generic;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetAllIngredientsInRestaurant;

public class IngredientsInRestaurantVm
{
    public ICollection<IngredientDto> IngredientDtos { get; set; } = new List<IngredientDto>();
}