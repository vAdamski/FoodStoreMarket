using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.ValueObjects;

namespace FoodStoreMarket.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<Product> Products { get; private set; } = new List<Product>();
        public Adres Adres { get; set; }
        public DateTime DateOfCreate { get; set; }
        public DateTime? DateOfAccepted { get; set; }
        public DateTime? DateOfScheduledDelivery { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
