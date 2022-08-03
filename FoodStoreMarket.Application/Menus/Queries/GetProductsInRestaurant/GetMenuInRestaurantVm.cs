using System.Collections.Generic;

namespace FoodStoreMarket.Application.Products.Queries.GetProductsInRestaurant;

public class GetMenuInRestaurantVm
{
    public List<GetMenuProductInRestaurantDto> ProductsInRestaurant { get; set; } = new List<GetMenuProductInRestaurantDto>();
}