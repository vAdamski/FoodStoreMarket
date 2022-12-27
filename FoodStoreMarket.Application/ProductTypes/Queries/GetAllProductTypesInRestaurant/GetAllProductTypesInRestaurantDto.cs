using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant;

public class GetAllProductTypesInRestaurantDto
{
    public int ProductTypeId { get; set; }
    public string ProductTypeName { get; set; }

    
}