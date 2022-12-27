using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizesInRestaurant
{
    public class SizeInRestaurantDtoMapper : IMapFrom<Size>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Size, SizeInRestaurantDto>()
                .ForMember(x => x.Id, map => map.MapFrom(src => src.Id))
                .ForMember(x => x.SizeName, map => map.MapFrom(src => src.SizeName));
        }
    }
}
