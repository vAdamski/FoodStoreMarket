using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Products.Commands.AddNewProduct
{
	public class AddNewProductHandler : IRequestHandler<AddNewProductCommand, int>
	{
		private IFoodStoreMarketDbContext _context;
		private IMapper _mapper;
		public AddNewProductHandler(IFoodStoreMarketDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<int> Handle(AddNewProductCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var menu = await _context.Menus.Where(x => x.Id == request.MenuId && x.StatusId == 1)
					.FirstOrDefaultAsync(cancellationToken);

				if (menu == null)
				{
					throw new ObjectNotExistInDbException(request.MenuId, "Menu");
				}

				var productToAdd = _mapper.Map<Product>(request);
				await _context.Products.AddAsync(productToAdd, cancellationToken);
				
				try
				{
					await _context.SaveChangesAsync(cancellationToken);
				}
				catch (DbUpdateException)
				{
					throw new DbUpdateException("Saving to database error!");
				}
				
				var productSpecifaction = _mapper.Map<ProductSpecification>(request);
				productSpecifaction.ProductId = productToAdd.Id;

				await _context.ProductSpecifications.AddAsync(productSpecifaction, cancellationToken);
				try
				{
					await _context.SaveChangesAsync(cancellationToken);
				}
				catch (DbUpdateException)
				{
					throw new DbUpdateException("Saving to database error!");
				}

				return productToAdd.Id;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}

