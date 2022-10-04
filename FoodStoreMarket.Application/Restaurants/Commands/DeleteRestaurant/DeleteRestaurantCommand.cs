using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Restaurants.Commands.DeleteRestaurant
{
    public class DeleteRestaurantCommand : IRequest
    {
        public int IdRestaurantToDelete { get; set; }
    }
}
