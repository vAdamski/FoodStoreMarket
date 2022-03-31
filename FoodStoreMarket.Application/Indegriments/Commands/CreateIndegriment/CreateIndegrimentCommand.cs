using System;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Indegriments.Commands.CreateIndegriment
{
	public class CreateIndegrimentCommand : IRequest<int>, IMapFrom<CreateIndegrimentCommand>
	{
		public string Name { get; set; }
		public decimal Price { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateIndegrimentCommand,Indegriment>()
				.ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
				.ForMember(x => x.Price, map => map.MapFrom(src => src.Price));
		}
	}
}

