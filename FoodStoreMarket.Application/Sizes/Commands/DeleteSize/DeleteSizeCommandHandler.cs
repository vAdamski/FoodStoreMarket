using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Commands.DeleteSize;

public class DeleteSizeCommandHandler : IRequestHandler<DeleteSizeCommand>
{
    private IFoodStoreMarketDbContext _context;

    public DeleteSizeCommandHandler(IFoodStoreMarketDbContext context)
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
                throw new ObjectNotExistInDbException(request.SizeIdToDelete, "Size");
            }

            _context.Sizes.Remove(sizeToDelete);
            
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