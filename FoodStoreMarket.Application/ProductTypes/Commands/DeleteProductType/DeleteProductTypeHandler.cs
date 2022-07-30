using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductTypes.Commands.DeleteProductType;

public class DeleteProductTypeHandler : IRequestHandler<DeleteProductTypeCommand>
{
    private IFoodStoreMarketDbContext _context;

    public DeleteProductTypeHandler(IFoodStoreMarketDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteProductTypeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var productTypeToDelete = await _context.ProductTypes.Where(x => x.Id == request.ProductTypeId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if (productTypeToDelete == null)
            {
                throw new ObjectNotExistInDbException(request.ProductTypeId, "Product Type");
            }

            _context.ProductTypes.Remove(productTypeToDelete);
            
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return Unit.Value;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}