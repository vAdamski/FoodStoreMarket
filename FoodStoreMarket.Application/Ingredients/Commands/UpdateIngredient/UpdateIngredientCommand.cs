using System;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Commands.UpdateIngredient;

public class UpdateIngredientCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }

    
}