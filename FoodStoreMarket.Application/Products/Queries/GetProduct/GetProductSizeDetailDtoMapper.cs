using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct
{
    public class GetProductSizeDetailDtoMapper : IMapFrom<ProductSizeSpecification>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ProductSizeSpecification, GetProductSizeDetailDto>()
                .ForMember(x => x.Price, map => map.MapFrom(src => src.Price))
                .ForMember(x => x.SizeId, map => map.MapFrom(src => src.Size.Id))
                .ForMember(x => x.SizeName, map => map.MapFrom(src => src.Size.SizeName));
        }
    }
}
