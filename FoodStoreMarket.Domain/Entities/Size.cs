using FoodStoreMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class Size : AuditableEntity
    {
        public string SizeName { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public List<ProductSizeSpecification> ProductSizeSpecifications { get; set; } = new List<ProductSizeSpecification>();
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}
