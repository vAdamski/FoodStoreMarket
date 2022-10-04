using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Queries.GetRestaurantDetail
{
    public class GetRestaurantDetailQueryHandler : IRequestHandler<GetRestaurantDetailQuery, RestaurantDetailVm>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;
        public GetRestaurantDetailQueryHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext,
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }
        public async Task<RestaurantDetailVm> Handle(GetRestaurantDetailQuery request, CancellationToken cancellationToken)
        {
            var restaurant = await _context.Restaurants.Where(r => r.Id == request.RestaurantId && r.StatusId == 1).FirstOrDefaultAsync(cancellationToken);

            if (restaurant == null) return null;

            restaurant.RestaurantSpecification = await _context.RestaurantSpecifications.Where(rs => rs.RestaurantId == request.RestaurantId).FirstOrDefaultAsync(cancellationToken);

            if (restaurant.RestaurantSpecification == null) return null;
            
            var restaurantVm = _mapper.Map<RestaurantDetailVm>(restaurant);

            return restaurantVm;
        }
    }
}
