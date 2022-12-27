using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetProductType
{
    public class ProductTypeVmMapper : IMapFrom<ProductType>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ProductType, ProductTypeVm>()
                .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductTypeName));
        }
    }
}
