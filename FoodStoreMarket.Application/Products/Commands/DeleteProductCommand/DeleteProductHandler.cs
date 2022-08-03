using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Products.Commands.DeleteProductCommand;

public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, bool>
{
    private IFoodStoreMarketDbContext _context;

    public DeleteProductHandler(IFoodStoreMarketDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
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