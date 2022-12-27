using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType;

public class CreateProdcutTypeCommand : IRequest<int>
{
    public int MenuId { get; set; }
    public string ProductTypeName { get; set; }

    
}
