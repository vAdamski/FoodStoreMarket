using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.ProductTypes.Queries.GetAllProductTypesInRestaurant;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant
{
    public class GetAllProductTypesInRestaurantDtoMapper : IMapFrom<ProductType>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ProductType, GetAllProductTypesInRestaurantDto>()
                .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.Id))
                .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductTypeName));
        }
    }
}
