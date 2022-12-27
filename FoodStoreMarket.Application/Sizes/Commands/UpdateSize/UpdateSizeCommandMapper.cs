using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Sizes.Commands.UpdateSize
{
    public class UpdateSizeCommandMapper : IMapFrom<UpdateSizeCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateSizeCommand, Size>()
                .ForMember(x => x.SizeName, map => map.MapFrom(src => src.SizeName))
                .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId))
                .IgnoreAllNonExisting();
        }
    }
}
