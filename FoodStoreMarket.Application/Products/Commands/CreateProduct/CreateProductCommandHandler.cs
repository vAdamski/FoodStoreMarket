using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using FoodStoreMarket.Shared.Models.Products.Commands.CreateProduct;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Products.Commands.CreateProduct
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
	{
		private IFoodStoreMarketDbContext _context;
		private IMapper _mapper;
		public CreateProductCommandHandler(IFoodStoreMarketDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
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
				
				var ingredientsInRestaurant = await _context.Ingredients
					.Where(x => x.MenuId == request.MenuId && x.StatusId == 1).ToListAsync(cancellationToken);
				
				var productSpecifaction = _mapper.Map<ProductSpecification>(request);
				productSpecifaction.ProductId = productToAdd.Id;
				
				request.IngredientsId.ForEach(ingredientId =>
				{
					var ingredient = ingredientsInRestaurant.Where(x => x.Id == ingredientId && x.StatusId == 1).FirstOrDefault();

					if (ingredient == null)
					{
						throw new ObjectNotExistInDbException(ingredientId, "Ingredient");
					}
                
					productSpecifaction.Ingredients.Add(ingredient);
				});
				

				await _context.ProductSpecifications.AddAsync(productSpecifaction, cancellationToken);
				try
				{
					await _context.SaveChangesAsync(cancellationToken);
				}
				catch (DbUpdateException)
				{
					throw new DbUpdateException("Saving to database error!");
				}

				productToAdd.ProductSpecificationId = productSpecifaction.Id;

				_context.Products.Update(productToAdd);
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

