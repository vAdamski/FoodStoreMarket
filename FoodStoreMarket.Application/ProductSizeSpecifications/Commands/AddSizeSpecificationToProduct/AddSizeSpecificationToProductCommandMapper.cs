using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct;

namespace FoodStoreMarket.Application.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct
{
    public class AddSizeSpecificationToProductCommandMapper : IMapFrom<AddSizeSpecificationToProductCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddSizeSpecificationToProductCommand, ProductSizeSpecification>()
                .ForMember(x => x.SizeId, map => map.MapFrom(src => src.SizeId))
                .ForMember(x => x.Price, map => map.MapFrom(src => src.Price))
                .IgnoreAllNonExisting();
        }
    }
}
