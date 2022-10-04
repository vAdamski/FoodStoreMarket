using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductSizeDetailDto : IMapFrom<ProductSizeSpecification>
{
    public int SizeId { get; set; }
    public string SizeName { get; set; }
    public decimal Price { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<ProductSizeSpecification, GetProductSizeDetailDto>()
            .ForMember(x => x.Price, map => map.MapFrom(src => src.Price))
            .ForMember(x => x.SizeId, map => map.MapFrom(src => src.Size.Id))
            .ForMember(x => x.SizeName, map => map.MapFrom(src => src.Size.SizeName));
    }
}