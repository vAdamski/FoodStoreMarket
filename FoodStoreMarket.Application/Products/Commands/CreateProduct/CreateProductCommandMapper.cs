using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Shared.Models.Products.Commands.CreateProduct;

namespace FoodStoreMarket.Application.Products.Commands.CreateProduct
{
    internal class CreateProductCommandMapper : IMapFrom<CreateProductCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductCommand, ProductSpecification>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
                .ForMember(x => x.Description, map => map.MapFrom(src => src.Description))
                .ForMember(x => x.ProductTypeId, map => map.MapFrom(src => src.ProductTypeId))
                .IgnoreAllNonExisting();

            profile.CreateMap<CreateProductCommand, Product>()
                .ForMember(x => x.MenuId, map => map.MapFrom(src => src.MenuId))
                .IgnoreAllNonExisting();
        }
    }
}
