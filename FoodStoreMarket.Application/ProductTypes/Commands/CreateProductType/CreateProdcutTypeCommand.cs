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

public class CreateProdcutTypeCommand : IRequest<int>, IMapFrom<CreateProdcutTypeCommand>
{
    public int MenuId { get; set; }
    public string ProductTypeName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateProdcutTypeCommand, ProductType>()
            .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductTypeName))
            .ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId))
            .IgnoreAllNonExisting();
    }
}
