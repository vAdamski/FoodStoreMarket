﻿using System.Collections.Generic;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Menus.Queries.GetProductsInRestaurant;

public class GetMenuProductInRestaurantDto : IMapFrom<Product>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double LowestPrice { get; set; }
    public List<GetMenuInRestaurantProductIngredientDto> Ingredients { get; set; } =
        new List<GetMenuInRestaurantProductIngredientDto>();

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Product, GetMenuProductInRestaurantDto>()
            .ForMember(x => x.ProductId, map => map.MapFrom(src => src.Id))
            .ForMember(x => x.ProductName, map => map.MapFrom(src => src.ProductSpecification.Name))
            .ForMember(x => x.Ingredients, map => map.Ignore())
            .ForMember(x => x.LowestPrice, map => map.Ignore());
    }
}