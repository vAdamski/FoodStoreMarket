using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities
{
    public class ProductSpecification : AuditableEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Indegriment> Indegriments { get; private set; } = new List<Indegriment>();
    }
}
