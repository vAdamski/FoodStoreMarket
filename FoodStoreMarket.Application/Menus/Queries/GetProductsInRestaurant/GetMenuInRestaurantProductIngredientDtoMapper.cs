using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Menus.Queries.GetProductsInRestaurant
{
    public class GetMenuInRestaurantProductIngredientDtoMapper : IMapFrom<Ingredient>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Ingredient, GetMenuInRestaurantProductIngredientDto>()
                .ForMember(x => x.IngredientName, map => map.MapFrom(src => src.Name));
        }
    }
}
