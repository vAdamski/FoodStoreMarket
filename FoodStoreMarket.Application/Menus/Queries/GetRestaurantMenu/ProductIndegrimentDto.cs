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
    public class ProductIndegrimentDto : IMapFrom<Ingredient>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Ingredient, ProductIndegrimentDto>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name));
        }
    }
}
