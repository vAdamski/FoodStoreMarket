using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using FoodStoreMarket.Shared.Models.Sizes.Commands.CreateSize;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Commands.CreateSize;

public class CreateSizeCommandHandler : IRequestHandler<CreateSizeCommand, int>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public CreateSizeCommandHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateSizeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var menuIsValid = await _context.Menus.Where(x => x.Id == request.MenuId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            var productTypeIsValid = await _context.ProductTypes
                .Where(x => x.Id == request.ProductTypeId && x.StatusId == 1).FirstOrDefaultAsync(cancellationToken);

            if (menuIsValid == null)
            {
                throw new ObjectNotExistInDbException(request.MenuId, "Menu");
            }

            if (productTypeIsValid == null)
            {
                throw new ObjectNotExistInDbException(request.ProductTypeId, "Product type");
            }

            var sizeToAdd = _mapper.Map<Size>(request);

            await _context.Sizes.AddAsync(sizeToAdd, cancellationToken);

            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return sizeToAdd.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}