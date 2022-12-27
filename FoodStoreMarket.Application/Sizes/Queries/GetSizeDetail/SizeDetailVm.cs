using AutoMapper;
using FoodStoreMarket.Application.Common.Mappings;
using FoodStoreMarket.Domain.Entities;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizeDetail;

public class SizeDetailVm
{
    public int Id { get; set; }
    public string SizeName { get; set; }
}