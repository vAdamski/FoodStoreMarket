using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities
{
    public class Menu : AuditableEntity
    {
        public int? RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Product> Products { get; private set; } = new List<Product>();
    }
}
