using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant;

public class GetAllProductTypesInRestaurantDto : IMapFrom<ProductType>
{
    public int ProductTypeId { get; set; }
    public string ProductTypeName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<ProductType, GetAllProductTypesInRestaurantDto>()
            .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.Id))
            .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductTypeName));
    }
}