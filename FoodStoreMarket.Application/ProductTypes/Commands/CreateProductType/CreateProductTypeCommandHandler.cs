using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using FoodStoreMarket.Shared.Models.ProductTypes.Commands.CreateProductType;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;

public class CreateProductTypeCommandHandler : IRequestHandler<CreateProdcutTypeCommand, int>
{

    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public CreateProductTypeCommandHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateProdcutTypeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var menu = await _context.Menus.Where(x => x.Id == request.MenuId)
                .FirstOrDefaultAsync(cancellationToken);

            if (menu == null)
            {
                throw new ObjectNotExistInDbException(request.MenuId, "Menu");
            }

            var productTypeToAdd = _mapper.Map<ProductType>(request);
            productTypeToAdd.Menu = menu;

            await _context.ProductTypes.AddAsync(productTypeToAdd, cancellationToken);

            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return productTypeToAdd.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}