using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommand : IRequest<int>, IMapFrom<CreateRestaurantCommand>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
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
                .ForPath(x => x.Adres.Email, map => map.MapFrom(src => src.Email));
        }
    }
}
