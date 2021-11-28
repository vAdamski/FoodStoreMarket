using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities
{
    public class Restaurant : AuditableEntity
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int RestaurantSpecificationId { get; set; }
        public RestaurantSpecification RestaurantSpecification { get; set; }
    }
}
