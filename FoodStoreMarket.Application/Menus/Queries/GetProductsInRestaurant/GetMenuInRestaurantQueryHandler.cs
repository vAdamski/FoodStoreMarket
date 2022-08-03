using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Products.Queries.GetProductsInRestaurant;

public class GetMenuInRestaurantQueryHandler : IRequestHandler<GetMenuInRestaurantQuery, GetMenuInRestaurantVm>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public GetMenuInRestaurantQueryHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetMenuInRestaurantVm> Handle(GetMenuInRestaurantQuery request, CancellationToken cancellationToken)
    {
        var restaurant = await _context.Restaurants
            .Where(x => x.Id == request.RestaurantId && x.StatusId == 1).FirstOrDefaultAsync(cancellationToken);
        
        if (restaurant == null)
        {
            throw new ObjectNotExistInDbException(request.RestaurantId, "Restaurant");
        }
        
        

        var vm = new GetMenuInRestaurantVm();
        
        productsInRestaurant
    }
}