using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetAllIngredientsInRestaurant;

public class IngredientDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    
}