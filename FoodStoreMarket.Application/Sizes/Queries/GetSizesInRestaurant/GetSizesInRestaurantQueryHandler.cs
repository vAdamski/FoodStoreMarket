using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Shared.Models.Sizes.Queries.GetSizesInRestaurant;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizesInRestaurant;

public class GetSizesInMenuQueryHandler : IRequestHandler<GetSizesInRestaurantQuery, SizesInRestaurantVm>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public GetSizesInMenuQueryHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<SizesInRestaurantVm> Handle(GetSizesInRestaurantQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var sizesInMenu = await _context.Sizes.Where(x => x.MenuId == request.RestaurantId && x.StatusId == 1)
                .ToListAsync(cancellationToken);

            var vm = new SizesInRestaurantVm();
            
            sizesInMenu.ForEach(size => vm.SizeInMenuDtos.Add(_mapper.Map<SizeInRestaurantDto>(size)));

            return vm;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}