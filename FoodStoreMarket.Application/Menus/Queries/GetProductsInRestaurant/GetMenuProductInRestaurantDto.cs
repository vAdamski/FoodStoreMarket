using System.Collections.Generic;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProductsInRestaurant;

public class GetMenuProductInRestaurantDto : IMapFrom<Product>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal LowestPrice { get; set; }
    public List<GetMenuInRestaurantProductIngredientDto> Ingredients { get; set; } =
        new List<GetMenuInRestaurantProductIngredientDto>();

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Product, GetMenuProductInRestaurantDto>()
            .ForMember(x => x.ProductId, map => map.MapFrom(src => src.Id))
            .ForMember(x => x.ProductName, map => map.MapFrom(src => src.ProductSpecification.Name));
    }
}