using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Commands.EditSize;

public class EditSizeHandler : IRequestHandler<EditSizeCommand, int>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public EditSizeHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(EditSizeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var sizeToUpdate = await _context.Sizes.Where(x => x.Id == request.SizeId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if (sizeToUpdate == null)
            {
                throw new Exception($"Size with Id = {request.SizeId} not exist!");
            }

            sizeToUpdate.SizeName = request.SizeName;
            sizeToUpdate.ProductTypeId = request.ProductTypeId;

            _context.Sizes.Update(sizeToUpdate);
            await _context.SaveChangesAsync(cancellationToken);

            return sizeToUpdate.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}