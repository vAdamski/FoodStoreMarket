using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Commands.AddNewSize;

public class AddNewSizeHandler : IRequestHandler<AddNewSizeCommand, int>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public AddNewSizeHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(AddNewSizeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var menuIsValid = await _context.Menus.Where(x => x.Id == request.MenuId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            var productTypeIsValid = await _context.ProductTypes
                .Where(x => x.Id == request.ProductTypeId && x.StatusId == 1).FirstOrDefaultAsync(cancellationToken);

            if (menuIsValid == null)
            {
                throw new Exception("Menu not exist!");
            }

            if (productTypeIsValid == null)
            {
                throw new Exception("Product type not exist!");
            }
            
            var sizeToAdd = _mapper.Map<Size>(request);

            await _context.Sizes.AddAsync(sizeToAdd, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return sizeToAdd.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}