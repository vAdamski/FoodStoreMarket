using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Products.Queries.GetProduct;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductVm>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public GetProductQueryHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetProductVm> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var product = await _context.Products
                .Where(x => x.Id == request.ProductId && x.StatusId == 1)
                .Include(x => x.ProductSpecification)
                .ThenInclude(x => x.Ingredients)
                .Include(x => x.ProductSpecification)
                .ThenInclude(x => x.ProductSizeSpecifications)
                .ThenInclude(x => x.Size)
                .Include(x => x.ProductSpecification)
                .ThenInclude(x => x.ProductType)
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null)
            {
                throw new ObjectNotExistInDbException(request.ProductId, "Product");
            }

            var vm = _mapper.Map<GetProductVm>(product);
        
            product.ProductSpecification.Ingredients.ForEach(i =>
            {
                vm.ProductIngredientDtos.Add(_mapper.Map<GetProductIngredientDto>(i));
            });
        
            product.ProductSpecification.ProductSizeSpecifications.ForEach(pss =>
            {
                vm.ProductSizeDetailDtos.Add(_mapper.Map<GetProductSizeDetailDto>(pss));
            });
        
            return vm;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}