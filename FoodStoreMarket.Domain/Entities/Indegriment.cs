using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities
{
    public class Indegriment : AuditableEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductSpecification> ProductSpecifications { get; set; }
    }
}
