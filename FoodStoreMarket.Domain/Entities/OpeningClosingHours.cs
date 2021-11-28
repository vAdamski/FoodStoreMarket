using System;
using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.ValueObjects;

namespace FoodStoreMarket.Domain.Entities
{
    public class OpeningClosingHours : AuditableEntity
    {
        public int OpeningClosingSpecificationId { get; set; }
        public OpeningClosingSpecification OpeningClosingSpecification { get; set; }

        public string Day { get; set; }
        public Time? OpeningTime { get; set; }
        public Time? ClosingTime { get; set; }
    }
}