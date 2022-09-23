using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.ValueObjects;
using MediatR;

namespace FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand, int>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public CreateRestaurantCommandHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext, 
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurant = new Restaurant();
            _context.Restaurants.Add(restaurant);

            await _context.SaveChangesAsync(cancellationToken);

            //RestaurantSpecification restaurantSpecification = MapRestaurantSpecifiaction(request);
            RestaurantSpecification restaurantSpecification = _mapper.Map<RestaurantSpecification>(request);
            restaurantSpecification.RestaurantId = restaurant.Id;
            _context.RestaurantSpecifications.Add(restaurantSpecification);
            
            var menu = new Menu();
            menu.RestaurantId = restaurant.Id;
            _context.Menus.Add(menu);

            await _context.SaveChangesAsync(cancellationToken);
            
            return restaurant.Id;
        }
    }
}
