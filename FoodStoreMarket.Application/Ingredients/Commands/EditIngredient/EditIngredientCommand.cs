using System;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Commands.EditIngredient;

public class EditIngredientCommand : IRequest<bool>, IMapFrom<EditIngredientCommand>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<EditIngredientCommand, Ingredient>()
            .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
            .ForMember(x => x.Price, map => map.MapFrom(src => src.Price));
    }
}