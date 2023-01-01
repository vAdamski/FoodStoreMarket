using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Ingredients.Queries.GetAllIngredientsInRestaurant;

namespace FoodStoreMarket.Application.Ingredients.Queries.GetAllIngredientsInRestaurant
{
    public class IngredientDtoMapper : IMapFrom<Ingredient>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Ingredient, IngredientDto>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
                .IgnoreAllNonExisting();
        }
    }
}
