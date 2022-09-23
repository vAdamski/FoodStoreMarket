using System;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Commands.UpdateIngredient;

public class UpdateIngredientCommand : IRequest<bool>, IMapFrom<UpdateIngredientCommand>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<UpdateIngredientCommand, Ingredient>()
            .ForMember(x => x.Name, map => map.MapFrom(src => src.Name));
    }
}