using System;
using MediatR;

namespace FoodStoreMarket.Application.Products.Commands.AddNewProduct
{
	public class AddNewProductCommand : IRequest<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal BasePrice { get; set; }

	}
}

