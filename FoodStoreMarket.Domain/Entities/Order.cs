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
        public ICollection<Product> Products { get; set; }
        public Adres Adres { get; set; }
    }
}
