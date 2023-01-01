using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using FoodStoreMarket.Domain.ValueObjects;
using FoodStoreMarket.Shared.Models.Restaurants.Commands.CreateRestaurant;
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
            try
            {
                await ValidRequest(request);
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private Task ValidRequest(CreateRestaurantCommand request)
        {
            if (string.IsNullOrEmpty(request.Name)) 
                throw new InvalidRequestException(request.GetType(), "Name", "Name is null or empty");
            if (request.Name?.Length > 100) 
                throw new InvalidRequestException(request.GetType(), "Name", "Name is longer then 100 chars");
            if (request.Description == null) 
                throw new InvalidRequestException(request.GetType(), "Description", "Description is null");
            if (request.Description.Length > 100) 
                throw new InvalidRequestException(request.GetType(), "Description", "Description is longer then 100 chars");
            if (request.City == null) 
                throw new InvalidRequestException(request.GetType(), "City", "City is null");
            if (request.City.Length > 25) 
                throw new InvalidRequestException(request.GetType(), "City", "City is longer then 25 chars");
            if (request.PostCode == null) 
                throw new InvalidRequestException(request.GetType(), "PostCode", "PostCode is null");
            if (request.PostCode.Length > 10) 
                throw new InvalidRequestException(request.GetType(), "PostCode", "PostCode is longer then 10 chars");
            if (string.IsNullOrEmpty(request.Street)) 
                throw new InvalidRequestException(request.GetType(), "Street", "Street is null or empty");
            if (request.Street.Length > 25) 
                throw new InvalidRequestException(request.GetType(), "Street", "Street is longer then 25 chars");
            if (string.IsNullOrEmpty(request.HouseNumber)) 
                throw new InvalidRequestException(request.GetType(), "HouseNumber", "HouseNumber is null");
            if (request.HouseNumber.Length > 5) 
                throw new InvalidRequestException(request.GetType(), "HouseNumber", "HouseNumber is longer then 5 chars");
            if (request.FlatNumber == null) 
                throw new InvalidRequestException(request.GetType(), "FlatNumber", "FlatNumber is null");
            if (request.FlatNumber.Length > 20) 
                throw new InvalidRequestException(request.GetType(), "FlatNumber", "FlatNumber is longer then 20 chars");
            if (request.PhoneNumber == null) 
                throw new InvalidRequestException(request.GetType(), "PhoneNumber", "PhoneNumber is null");
            if (request.PhoneNumber.Length < 7) 
                throw new InvalidRequestException(request.GetType(), "PhoneNumber", "PhoneNumber is shorter then 7 chars");
            if (request.PhoneNumber.Length > 10) 
                throw new InvalidRequestException(request.GetType(), "PhoneNumber", "PhoneNumber is longer then 10 chars");
            if (request.Email == null) 
                throw new InvalidRequestException(request.GetType(), "Email", "Email is null");
            if (!request.Email.Contains('@'))
                throw new InvalidRequestException(request.GetType(), "Email", "Email is not email");

            return Task.CompletedTask;
        }
    }
}
