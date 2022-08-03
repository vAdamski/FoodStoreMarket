using System;
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
        try
        {
            var restaurant = await _context.Restaurants
                .Where(x => x.Id == request.RestaurantId && x.StatusId == 1).Include(x => x.Menu).FirstOrDefaultAsync(cancellationToken);
        
            if (restaurant?.Menu == null)
            {
                throw new ObjectNotExistInDbException(request.RestaurantId, "Restaurant");
            }
        
            var vm = new GetMenuInRestaurantVm();

            var products = await _context.Products
                .Where(x => x.MenuId == restaurant.Menu.Id)
                .Include(x => x.ProductSpecification)
                .ThenInclude(x => x.Ingredients)
                .Include(x => x.ProductSpecification)
                .ThenInclude(x => x.ProductSizeSpecifications)
                .ToListAsync(cancellationToken);
            
            products.ForEach(p =>
            {
                var productDto = _mapper.Map<GetMenuProductInRestaurantDto>(p);
                productDto.LowestPrice = p.ProductSpecification.ProductSizeSpecifications.Min(x => x.Price);
                p.ProductSpecification.Ingredients.ForEach(i =>
                {
                    productDto.Ingredients.Add(_mapper.Map<GetMenuInRestaurantProductIngredientDto>(i));
                });

                vm.ProductsInRestaurant.Add(productDto);
            });

            return vm;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}