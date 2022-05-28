using FoodStoreMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class ComponentSizeDetail : AuditableEntity
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public decimal Price { get; set; }
        public ProductSpecification ProductSpecification { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}

//ComponteSizeDetail(stworzyć 2 klasy dzieciczące): 
//- IngredientSizeDetail
//- ProductSizeDetail

//Size:
//(dodać)
//- List IngredientSizeDetail
//- List ProductSizeDetail
//(Usunać)
//- List ComponteSizeDetail