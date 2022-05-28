using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.Entities
{
    public class Ingredient : AuditableEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public List<ProductSpecification> ProductSpecifications { get; private set; } = new List<ProductSpecification>();
        public List<ComponentSizeDetail> ComponentSizes { get; private set; } = new List<ComponentSizeDetail>();
    }
}
