using FoodStoreMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class ProductType : AuditableEntity
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public string ProductTypeName { get; set; }
        public List<ProductSpecification> ProductSpecifications { get; set; } = new List<ProductSpecification>();
        public List<Size> Sizes { get; set; } = new List<Size>();
    }
}
