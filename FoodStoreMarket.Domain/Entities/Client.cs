using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.ValueObjects;

namespace FoodStoreMarket.Domain.Entities
{
    public class Client : AuditableEntity
    {
        public PersonName PersonName { get; set; }
        public Adres Adres { get; set; }
    }
}