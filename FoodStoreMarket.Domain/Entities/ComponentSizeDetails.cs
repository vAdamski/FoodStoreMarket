using FoodStoreMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class ComponentSizeDetails : AuditableEntity
    {
        public int MenuId { get; set; }
        public Size Size { get; set; }
        public decimal Price { get; set; }
        public int? ProductSpecificationId { get; set; }
        public ProductSpecification ProductSpecification { get; set; }
        public int? IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
