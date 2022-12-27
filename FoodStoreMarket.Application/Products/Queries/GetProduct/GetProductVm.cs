using System.Collections.Generic;
using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductVm
{
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string ProductTypeName { get; set; }
    public List<GetProductIngredientDto> ProductIngredientDtos { get; private set; } = new List<GetProductIngredientDto>();
    public List<GetProductSizeDetailDto> ProductSizeDetailDtos { get; private set; } = new List<GetProductSizeDetailDto>();

    
}