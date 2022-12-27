using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductIngredientDto
{
    public string IngredientId { get; set; }
    public string IngredientName { get; set; }

    
}