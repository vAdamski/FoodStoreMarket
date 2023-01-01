using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Ingredients.Commands.CreateIngredient;

namespace FoodStoreMarket.Application.Ingredients.Commands.CreateIngredient
{
    public class CreateIngredientCommandMapper : IMapFrom<CreateIngredientCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateIngredientCommand, Ingredient>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
                .ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId))
                .IgnoreAllNonExisting();
        }
    }
}
