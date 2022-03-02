using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Menus.Queries.GetRestaurantMenu
{
    public class GetRestaurantMenuQuery : IRequest<RestaurantMenuVm>
    {
        public int IdRestuarantMenu { get; set; }
    }
}
