using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant
{
    public class DeleteRestaurantCommandHandler : IRequestHandler<DeleteRestaurantCommand>
    {
        private readonly IFoodStoreMarketDbContext _context;
        public DeleteRestaurantCommandHandler(IFoodStoreMarketDbContext foodStoreMarketDbContext)
        {
            _context = foodStoreMarketDbContext;
        }

        public async Task<Unit> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurantToDelete = await _context.Restaurants
                .Where(r => r.Id == request.IdRestaurantToDelete)
                .FirstOrDefaultAsync();

            restaurantToDelete.Menu = await _context.Menus
                .Where(m => m.RestaurantId == restaurantToDelete.Id)
                .FirstOrDefaultAsync();
            
            restaurantToDelete.RestaurantSpecification = await _context.RestaurantSpecifications
                .Where(rs => rs.RestaurantId == restaurantToDelete.Id)
                .FirstOrDefaultAsync();

            _context.Restaurants.Remove(restaurantToDelete);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
