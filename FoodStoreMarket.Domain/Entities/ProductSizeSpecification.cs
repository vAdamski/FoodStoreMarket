using FoodStoreMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class ProductSizeSpecification : AuditableEntity
    {
        public int ProductSpecificationId { get; set; }
        public ProductSpecification ProductSpecification { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public decimal Price { get; set; }
    }
}
