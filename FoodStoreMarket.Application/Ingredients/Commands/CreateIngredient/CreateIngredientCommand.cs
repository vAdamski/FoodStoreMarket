using System;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Commands.CreateIngredient
{
	public class CreateIngredientCommand : IRequest<int>
	{
        public int MenuId { get; set; }
		public string Name { get; set; }
	}
}

