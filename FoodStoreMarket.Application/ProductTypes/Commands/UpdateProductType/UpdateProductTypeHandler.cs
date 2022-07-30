using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductTypes.Commands.UpdateProductType;

public class UpdateProductTypeHandler : IRequestHandler<UpdateProductTypeCommand, int>
{
    private IFoodStoreMarketDbContext _context;

    public UpdateProductTypeHandler(IFoodStoreMarketDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(UpdateProductTypeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var productType = await _context.ProductTypes.Where(x => x.Id == request.ProductTypeId)
                .FirstOrDefaultAsync(cancellationToken);

            if (productType == null)
            {
                throw new ObjectNotExistInDbException(request.ProductTypeId, "Product type");
            }

            productType.ProductTypeName = request.NewProductTypeName;
        
            _context.ProductTypes.Update(productType);
            
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return productType.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine("Product type has not been updated");
            throw;
        }
    }
}