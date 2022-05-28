using FoodStoreMarket.Domain.Common;
using System.Collections.Generic;

namespace FoodStoreMarket.Domain.Entities;

public class Size : AuditableEntity
{
    public int MenuId { get; set; }
    public Menu Menu { get; set; }
    public List<ComponentSizeDetail> ComponentSizeDetails { get; private set; } = new List<ComponentSizeDetail>();
    public string SizeName { get; set; }
}