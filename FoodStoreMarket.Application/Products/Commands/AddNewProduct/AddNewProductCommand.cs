using System;
using MediatR;

namespace FoodStoreMarket.Application.Products.Commands.AddNewProduct
{
	public class AddNewProductCommand : IRequest<int>
	{
		public int MenuId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}

