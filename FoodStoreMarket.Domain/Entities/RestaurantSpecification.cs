using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.ValueObjects;

namespace FoodStoreMarket.Domain.Entities
{
    public class RestaurantSpecification : AuditableEntity
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Adres Adres { get; set; }
        public DateTime OpeningHours { get; set; }
        public DateTime ClosingHours { get; set; }
    }
}
