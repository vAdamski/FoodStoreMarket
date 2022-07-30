using System;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Application.Sizes.Commands.AddNewSize;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Products.Commands.AddNewProduct
{
	public class AddNewProductCommand : IRequest<int>, IMapFrom<AddNewProductCommand>
	{
		public int MenuId { get; set; }
		public int ProductTypeId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		

		public void Mapping(Profile profile)
		{
			profile.CreateMap<AddNewProductCommand, ProductSpecification>()
				.ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
				.ForMember(x => x.Description, map => map.MapFrom(src => src.Description))
				.ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId));

			profile.CreateMap<AddNewProductCommand, Product>()
				.ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId));
		}
	}
}

