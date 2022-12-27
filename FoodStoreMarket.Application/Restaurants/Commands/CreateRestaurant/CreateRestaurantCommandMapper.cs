using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommandMapper : IMapFrom<CreateRestaurantCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateRestaurantCommand, RestaurantSpecification>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
                .ForMember(x => x.Description, map => map.MapFrom(src => src.Description))
                .ForPath(x => x.Adres.City, map => map.MapFrom(src => src.City))
                .ForPath(x => x.Adres.PostCode, map => map.MapFrom(src => src.PostCode))
                .ForPath(x => x.Adres.Street, map => map.MapFrom(src => src.Street))
                .ForPath(x => x.Adres.HouseNumber, map => map.MapFrom(src => src.HouseNumber))
                .ForPath(x => x.Adres.FlatNumber, map => map.MapFrom(src => src.FlatNumber))
                .ForPath(x => x.Adres.PhoneNumber, map => map.MapFrom(src => src.PhoneNumber))
                .ForPath(x => x.Adres.Email, map => map.MapFrom(src => src.Email))
                .IgnoreAllNonExisting();
        }
    }
}
