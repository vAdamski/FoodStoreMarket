﻿using FoodStoreMarket.Application.Interfaces;
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
    public class DeleteResturantHandler : IRequestHandler<DeleteRestaurantCommand>
    {
        private readonly IFoodStoreMarketDbContext _context;
        public DeleteResturantHandler(IFoodStoreMarketDbContext foodStoreMarketDbContext)
        {
            _context = foodStoreMarketDbContext;
        }

        public async Task<Unit> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurantToDelete = await _context.Restaurants.Where(r => r.Id == request.IdRestaurantToDelete).FirstOrDefaultAsync();

            _context.Restaurants.Remove(restaurantToDelete);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}