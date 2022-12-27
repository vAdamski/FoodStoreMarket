using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct
{
    public class GetProductIngredientDtoMapper : IMapFrom<Ingredient>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Ingredient, GetProductIngredientDto>()
                .ForMember(x => x.IngredientId, map => map.MapFrom(src => src.Id))
                .ForMember(x => x.IngredientName, map => map.MapFrom(src => src.Name));
        }
    }
}
