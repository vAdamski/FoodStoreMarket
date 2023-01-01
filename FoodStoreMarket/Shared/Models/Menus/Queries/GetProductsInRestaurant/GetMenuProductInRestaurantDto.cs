namespace FoodStoreMarket.Shared.Models.Menus.Queries.GetProductsInRestaurant;

public class GetMenuProductInRestaurantDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double LowestPrice { get; set; }

    public List<GetMenuInRestaurantProductIngredientDto> Ingredients { get; set; } = new();
}