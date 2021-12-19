using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int? ProductSpecificationId { get; set; }
        public ProductSpecification ProductSpecification { get; set; }
        public List<Order> Orders { get; private set; } = new List<Order>();
    }
}
