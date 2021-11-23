using FoodStoreMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Domain.Entities
{
    public class WorkingHours : AuditableEntity
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime DateOfStartWork { get; set; }
        public DateTime DateOfEndWork { get; set; }
        public decimal? WorkHours { get; set; }
    }
}
