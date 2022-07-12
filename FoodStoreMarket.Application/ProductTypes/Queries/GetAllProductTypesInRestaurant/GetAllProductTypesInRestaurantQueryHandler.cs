using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant;

public class GetAllProductTypesInRestaurantQueryHandler : IRequestHandler<GetAllProductTypesInRestaurantQuery, GetAllProductTypesInRestaurantVm>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public GetAllProductTypesInRestaurantQueryHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetAllProductTypesInRestaurantVm> Handle(GetAllProductTypesInRestaurantQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var menu = await _context.Menus.Where(x => x.RestaurantId == request.RestaurantId)
                .FirstOrDefaultAsync(cancellationToken);

            if (menu == null)
            {
                throw new Exception("Restaurant with this Id is not exist!");
                //TODO: Create exception "Restaurant is not exist"
            }

            var productTypesInRestaurant = await _context.ProductTypes.Where(x => x.MenuId == menu.Id)
                .ToListAsync(cancellationToken);

            var vm = new GetAllProductTypesInRestaurantVm();
            
            productTypesInRestaurant.ForEach(pt =>
            {
                var mappedEntity = _mapper.Map<GetAllProductTypesInRestaurantDto>(pt);
                vm.GetAllProductTypesInRestaurantDtos.Add(mappedEntity);
            });

            return vm;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}