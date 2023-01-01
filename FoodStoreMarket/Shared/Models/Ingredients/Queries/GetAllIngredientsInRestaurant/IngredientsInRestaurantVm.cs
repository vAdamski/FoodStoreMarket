namespace FoodStoreMarket.Shared.Models.Ingredients.Queries.GetAllIngredientsInRestaurant;

public class IngredientsInRestaurantVm
{
    public ICollection<IngredientDto> IngredientDtos { get; set; } = new List<IngredientDto>();
}