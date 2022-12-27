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
    public class GetProductVmMapper : IMapFrom<Product>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, GetProductVm>()
                .ForMember(x => x.ProductName, map => map.MapFrom(src => src.ProductSpecification.Name))
                .ForMember(x => x.Description, map => map.MapFrom(src => src.ProductSpecification.Description))
                .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductSpecification.ProductType.ProductTypeName))
                .IgnoreAllNonExisting();
        }
    }
}
