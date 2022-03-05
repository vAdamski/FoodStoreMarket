using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Menus.Queries.GetRestaurantMenu
{
    public class RestaurantProductDto : IMapFrom<Product>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProductIndegrimentDto> Indegriments { get; private set; } = new List<ProductIndegrimentDto>();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, RestaurantProductDto>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.));
        }
    }
}
