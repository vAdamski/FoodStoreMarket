using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Sizes.Commands.CreateSize
{
    public class CreateSizeCommandMapper : IMapFrom<CreateSizeCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateSizeCommand, Size>()
                .ForMember(x => x.SizeName, map => map.MapFrom(src => src.SizeName))
                .ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId))
                .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId))
                .IgnoreAllNonExisting();
        }
    }
}
