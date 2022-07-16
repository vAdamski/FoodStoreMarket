using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Commands.DeleteSize;

public class DeleteSizeHandler : IRequestHandler<DeleteSizeCommand>
{
    private IFoodStoreMarketDbContext _context;

    public DeleteSizeHandler(IFoodStoreMarketDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteSizeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var sizeToDelete = await _context.Sizes.Where(x => x.Id == request.SizeIdToDelete && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if (sizeToDelete == null)
            {
                throw new Exception($"Size with Id = {request.SizeIdToDelete} not exist!");
            }

            _context.Sizes.Remove(sizeToDelete);
            await _context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}