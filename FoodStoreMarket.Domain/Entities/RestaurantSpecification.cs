using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class RestaurantSpecification
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Adres { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime OpeningHours { get; set; }
        public DateTime ClosingHours { get; set; }

    }
}
