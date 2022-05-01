using FoodStoreMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class ProductSize : AuditableEntity
    {
        public int MenuId { get; set; }
        public int ProductId { get; set; }
        public string SizeName { get; set; }
        public decimal Price { get; set; }
        public int ProductSpecificatrionId { get; set; }
        public ProductSpecification ProductSpecification { get; set; }
    }
}
