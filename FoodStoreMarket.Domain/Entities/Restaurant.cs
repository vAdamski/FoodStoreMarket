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
        public virtual Menu Menu { get; set; }
        public virtual RestaurantSpecification RestaurantSpecification { get; set; }
    }
}
