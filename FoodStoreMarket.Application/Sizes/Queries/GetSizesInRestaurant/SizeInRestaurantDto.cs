using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizesInRestaurant;

public class SizeInRestaurantDto
{
    public int Id { get; set; }
    public string SizeName { get; set; }
}