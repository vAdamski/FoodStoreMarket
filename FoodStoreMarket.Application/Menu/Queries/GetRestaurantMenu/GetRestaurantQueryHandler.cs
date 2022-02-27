using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Menu.Queries.GetRestaurantMenu
{
    internal class GetRestaurantQueryHandler : IRequestHandler<GetRestaurantMenuQuery, RestaurantMenuVm>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public GetRestaurantQueryHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext,
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }

        public async Task<RestaurantMenuVm> Handle(GetRestaurantMenuQuery request, CancellationToken cancellationToken)
        {
            var menu = await _context.Menus.Where(m => m.RestaurantId == request.IdRestuarantMenu).FirstOrDefaultAsync(cancellationToken);

            if(menu != null)
            {
                var productsInRestaurantMenu = _context.Products.Where(p => p.MenuId == menu.Id).ToList();

                productsInRestaurantMenu.ForEach(product =>
                {
                    menu.Products.Add(product);
                });
            }

            RestaurantMenuVm vm = new RestaurantMenuVm();

            return vm;
        }
    }
}
