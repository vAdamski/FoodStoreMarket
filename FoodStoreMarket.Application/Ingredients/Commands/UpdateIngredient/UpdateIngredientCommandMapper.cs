using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Ingredients.Commands.UpdateIngredient;

namespace FoodStoreMarket.Application.Ingredients.Commands.UpdateIngredient
{
    public class UpdateIngredientCommandMapper : IMapFrom<UpdateIngredientCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateIngredientCommand, Ingredient>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
                .IgnoreAllNonExisting();
        }
    }
}
