using System.Collections.Generic;

namespace FoodStoreMarket.Application.Products.Queries.GetProductsInRestaurant;

public class GetMenuInRestaurantVm
{
    public List<GetMenuInRestaurantDto> ProductsInRestaurant { get; set; } = new List<GetMenuInRestaurantDto>();
}