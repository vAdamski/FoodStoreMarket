using System.Collections.Generic;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Menus.Queries.GetProductsInRestaurant;

public class GetMenuProductInRestaurantDto 
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double LowestPrice { get; set; }
    public List<GetMenuInRestaurantProductIngredientDto> Ingredients { get; set; } =
        new List<GetMenuInRestaurantProductIngredientDto>();
}