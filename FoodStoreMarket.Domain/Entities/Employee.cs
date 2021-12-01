using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public int RestaurantSpecificationId { get; set; }
        public RestaurantSpecification RestaurantSpecification { get; set; }
        public PersonName PersonName { get; set; }
        public Adres Adres { get; set; }
        public List<WorkingHours> WorkingHours { get; private set; } = new List<WorkingHours>();
    }
}