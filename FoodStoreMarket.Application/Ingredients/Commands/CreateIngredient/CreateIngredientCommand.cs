using System;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Commands.CreateIngredient
{
	public class CreateIngredientCommand : IRequest<int>, IMapFrom<CreateIngredientCommand>
	{
        public int MenuId { get; set; }
		public string Name { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateIngredientCommand,Ingredient>()
				.ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
				.ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId))
				.IgnoreAllNonExisting();
		}
	}
}

