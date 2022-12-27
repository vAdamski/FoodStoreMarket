using System;
using System.Collections.Generic;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Products.Commands.CreateProduct
{
	public class CreateProductCommand : IRequest<int>
	{
		public int MenuId { get; set; }
		public int ProductTypeId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public List<int> IngredientsId { get; set; }
	}
}

