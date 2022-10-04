using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetProductType;

public class ProductTypeVm : IMapFrom<ProductType>
{
    public string ProductTypeName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<ProductType, ProductTypeVm>()
            .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductTypeName));
    }
}