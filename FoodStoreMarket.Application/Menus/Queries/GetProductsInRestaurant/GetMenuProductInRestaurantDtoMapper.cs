using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Menus.Queries.GetProductsInRestaurant;

namespace FoodStoreMarket.Application.Menus.Queries.GetProductsInRestaurant
{
    internal class GetMenuProductInRestaurantDtoMapper : IMapFrom<Product>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, GetMenuProductInRestaurantDto>()
                .ForMember(x => x.ProductId, map => map.MapFrom(src => src.Id))
                .ForMember(x => x.ProductName, map => map.MapFrom(src => src.ProductSpecification.Name))
                .ForMember(x => x.Ingredients, map => map.Ignore())
                .ForMember(x => x.LowestPrice, map => map.Ignore());
        }
    }
}
