using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.ProductSpecifications.Commands.UpdateProductSpecification;

namespace FoodStoreMarket.Application.ProductSpecifications.Commands.UpdateProductSpecification
{
    public class UpdateProductSpecificationCommandMapper : IMapFrom<UpdateProductSpecificationCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateProductSpecificationCommand, ProductSpecification>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
                .ForMember(x => x.Description, map => map.MapFrom(src => src.Description))
                .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId))
                .IgnoreAllNonExisting();
        }
    }
}
