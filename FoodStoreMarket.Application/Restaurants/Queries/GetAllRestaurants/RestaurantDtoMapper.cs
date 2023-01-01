using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Restaurants.Queries.GetAllRestaurants;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetAllRestaurants
{
    public class RestaurantDtoMapper : IMapFrom<Restaurant>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Restaurant, RestaurantDto>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.RestaurantSpecification.Name))
                .ForMember(x => x.Description, map => map.MapFrom(src => src.RestaurantSpecification.Description));
        }
    }
}
