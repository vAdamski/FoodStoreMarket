using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Shared.Models.ProductTypes.Commands.CreateProductType;

namespace FoodStoreMarket.Application.ProductTypes.Commands.CreateProductType
{
    public class CreateProdcutTypeCommandMapper : IMapFrom<CreateProdcutTypeCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProdcutTypeCommand, ProductType>()
                .ForMember(x => x.ProductTypeName, map => map.MapFrom(src => src.ProductTypeName))
                .ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId))
                .IgnoreAllNonExisting();
        }
    }
}
