using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.ProductTypes.Commands.AddNewProductType
{
    public class AddNewProdcutTypeCommand : IRequest<int>, IMapFrom<AddNewProdcutTypeCommand>
    {
        public int MenuId { get; set; }
        public string ProductTypeName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddNewProdcutTypeCommand, ProductType>()
                .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductTypeName))
                .ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId));
        }
    }
}
