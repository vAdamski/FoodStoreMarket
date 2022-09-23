using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductSpecifications.Commands.UpdateProductSpecification;

public class UpdateProductSpecificationHandler : IRequestHandler<UpdateProductSpecificationCommand, bool>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public UpdateProductSpecificationHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<bool> Handle(UpdateProductSpecificationCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var productToEdit = await _context.Products.Where(x => x.Id == request.ProductId && x.StatusId == 1)
                .Include(x => x.ProductSpecification).FirstOrDefaultAsync(cancellationToken);

            if (productToEdit?.ProductSpecification == null)
            {
                throw new ObjectNotExistInDbException(request.ProductId, "Prduct");
            }

            var productSpec = productToEdit.ProductSpecification;
            var ingredientsInRestaurant = await _context.Ingredients
                .Where(x => x.MenuId == productToEdit.MenuId && x.StatusId == 1).ToListAsync(cancellationToken);

            productSpec.Name = request.Name;
            productSpec.Description = request.Description;
            productSpec.ProductTypeId = request.ProductTypeId;

            request.IngredientsId.ForEach(ingredientId =>
            {
                var ingredient = ingredientsInRestaurant.Where(x => x.Id == ingredientId && x.StatusId == 1).FirstOrDefault();

                if (ingredient == null)
                {
                    throw new ObjectNotExistInDbException(ingredientId, "Ingredient");
                }

                productSpec.Ingredients.Add(ingredient);
            });

            _context.ProductSpecifications.Update(productSpec);

            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}