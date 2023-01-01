using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FoodStoreMarket.Shared.Models.Products.Commands.DeleteProductCommand;

namespace FoodStoreMarket.Application.Products.Commands.DeleteProductCommand;

public class DeleteProductCommandHandler : IRequestHandler<Shared.Models.Products.Commands.DeleteProductCommand.DeleteProductCommand, bool>
{
    private IFoodStoreMarketDbContext _context;

    public DeleteProductCommandHandler(IFoodStoreMarketDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(Shared.Models.Products.Commands.DeleteProductCommand.DeleteProductCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var entityToDelete = await _context.Products.Where(x => x.Id == request.ProductId && x.StatusId == 1)
                .Include(x => x.ProductSpecification).FirstOrDefaultAsync(cancellationToken);
            
            Console.WriteLine(entityToDelete);
            
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}