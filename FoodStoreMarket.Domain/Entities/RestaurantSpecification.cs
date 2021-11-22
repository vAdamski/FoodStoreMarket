using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Common;
using FoodStoreMarket.Domain.ValueObjects;

namespace FoodStoreMarket.Domain.Entities
{
    public class RestaurantSpecification : AuditableEntity
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Adres Adres { get; set; }

        //Date of closing and opening restaurant
        public DateTime? MondayOpening { get; set; }
        public DateTime? MondayClosing { get; set; }
        public DateTime? TuesdayOpening { get; set; }
        public DateTime? TuesdayClosing { get; set; }
        public DateTime? WednesdayOpening { get; set; }
        public DateTime? WednesdayClosing { get; set; }
        public DateTime? ThursdayOpening { get; set; }
        public DateTime? ThursdayClosing { get; set; }
        public DateTime? FridayOpening { get; set; }
        public DateTime? FridayClosing { get; set; }
        public DateTime? SaturdayOpening { get; set; }
        public DateTime? SaturdayClosing { get; set; }
        public DateTime? SundayOpening { get; set; }
        public DateTime? SundayClosing { get; set; }
    }
}