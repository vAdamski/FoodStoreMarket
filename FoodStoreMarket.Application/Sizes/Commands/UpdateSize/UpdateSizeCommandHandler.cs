using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Commands.UpdateSize;

public class UpdateSizeCommandHandler : IRequestHandler<UpdateSizeCommand, int>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public UpdateSizeCommandHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateSizeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var sizeToUpdate = await _context.Sizes.Where(x => x.Id == request.SizeId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if (sizeToUpdate == null)
            {
                throw new ObjectNotExistInDbException(request.SizeId, "Size");
            }

            sizeToUpdate.SizeName = request.SizeName;
            sizeToUpdate.ProductTypeId = request.ProductTypeId;

            _context.Sizes.Update(sizeToUpdate);

            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return sizeToUpdate.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}