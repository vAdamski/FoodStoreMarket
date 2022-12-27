using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct;

public class AddSizeSpecificationToProductCommand : IRequest<int>
{
    public int ProductId { get; set; }
    public int SizeId { get; set; }
    public decimal Price { get; set; }

    
}