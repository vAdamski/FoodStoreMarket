using System;
using System.Collections.Generic;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Products.Commands.CreateProduct
{
	public class CreateProductCommand : IRequest<int>, IMapFrom<CreateProductCommand>
	{
		public int MenuId { get; set; }
		public int ProductTypeId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public List<int> IngredientsId { get; set; }
		
		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateProductCommand, ProductSpecification>()
				.ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
				.ForMember(x => x.Description, map => map.MapFrom(src => src.Description))
				.ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId));

			profile.CreateMap<CreateProductCommand, Product>()
				.ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId));
		}
	}
}

