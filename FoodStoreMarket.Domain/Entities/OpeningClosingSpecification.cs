using System;
using System.Collections.Generic;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities
{
    public class OpeningClosingSpecification : AuditableEntity
    {
        public int RestaurantSpecificationId { get; set; }
        public RestaurantSpecification RestaurantSpecification { get; set; }
        public List<OpeningClosingHours> OpeningClosingHours { get; private set; } = new List<OpeningClosingHours>();
    }
}

