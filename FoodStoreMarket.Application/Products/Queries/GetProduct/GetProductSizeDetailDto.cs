using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductSizeDetailDto
{
    public int SizeId { get; set; }
    public string SizeName { get; set; }
    public decimal Price { get; set; }
}