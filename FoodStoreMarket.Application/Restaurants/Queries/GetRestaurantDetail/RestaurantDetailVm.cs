using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail
{
    public class RestaurantDetailVm : IMapFrom<Restaurant>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Restaurant, RestaurantDetailVm>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.RestaurantSpecification.Name.FirstOrDefault()))
                .ForMember(x => x.Description, map => map.MapFrom(src => src.RestaurantSpecification.Description.FirstOrDefault()))
                .ForMember(x => x.City, map => map.MapFrom(src => src.RestaurantSpecification.Adres.City.FirstOrDefault()))
                .ForMember(x => x.PostCode, map => map.MapFrom(src => src.RestaurantSpecification.Adres.PostCode.FirstOrDefault()))
                .ForMember(x => x.Street, map => map.MapFrom(src => src.RestaurantSpecification.Adres.Street.FirstOrDefault()))
                .ForMember(x => x.HouseNumber, map => map.MapFrom(src => src.RestaurantSpecification.Adres.HouseNumber.FirstOrDefault()))
                .ForMember(x => x.PhoneNumber, map => map.MapFrom(src => src.RestaurantSpecification.Adres.PhoneNumber.FirstOrDefault()))
                .ForMember(x => x.Email, map => map.MapFrom(src => src.RestaurantSpecification.Adres.Email.FirstOrDefault()));
        }
    }
}
