using System.Collections.Generic;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductVm : IMapFrom<Product>
{
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string ProductTypeName { get; set; }
    public List<GetProductIngredientDto> ProductIngredientDtos { get; private set; } = new List<GetProductIngredientDto>();
    public List<GetProductSizeDetailDto> ProductSizeDetailDtos { get; private set; } = new List<GetProductSizeDetailDto>();

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Product, GetProductVm>()
            .ForMember(x => x.ProductName, map => map.MapFrom(src => src.ProductSpecification.Name))
            .ForMember(x => x.Description, map => map.MapFrom(src => src.ProductSpecification.Description))
            .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductSpecification.ProductType.ProductTypeName));
    }
}