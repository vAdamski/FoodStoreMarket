using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class Indegriment
    {
        public int Id { get; set; }
        public ICollection<ProductSpecification> ProductSpecifications { get; set; }
    }
}
