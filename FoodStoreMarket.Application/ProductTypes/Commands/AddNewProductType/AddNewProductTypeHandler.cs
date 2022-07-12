using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductTypes.Commands.AddNewProductType
{
    public class AddNewProductTypeHandler : IRequestHandler<AddNewProdcutTypeCommand, int>
    {
        
        private IFoodStoreMarketDbContext _context;
        private IMapper _mapper;
        
        public AddNewProductTypeHandler(IFoodStoreMarketDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<int> Handle(AddNewProdcutTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var menu = await _context.Menus.Where(x => x.Id == request.MenuId)
                    .FirstOrDefaultAsync(cancellationToken);

                if (menu == null)
                {
                    throw new Exception("Menu with this Id not exist in database");
                }

                var productTypeToAdd = _mapper.Map<ProductType>(request);
                productTypeToAdd.Menu = menu;

                await _context.ProductTypes.AddAsync(productTypeToAdd, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return productTypeToAdd.Id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
