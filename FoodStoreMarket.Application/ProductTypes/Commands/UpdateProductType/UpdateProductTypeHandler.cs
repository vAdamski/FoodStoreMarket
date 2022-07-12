using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
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
                throw new Exception("Product type not exist");
                //TODO: Exception Product type not exist
            }

            productType.ProductTypeName = request.NewProductTypeName;
        
            _context.ProductTypes.Update(productType);
            await _context.SaveChangesAsync(cancellationToken);

            return productType.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine("Product type has not been updated");
            throw;
        }
    }
}