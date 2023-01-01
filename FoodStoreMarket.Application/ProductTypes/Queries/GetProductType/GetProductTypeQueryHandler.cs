using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using FoodStoreMarket.Shared.Models.ProductTypes.Queries.GetProductType;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductTypes.Queries.GetProductType;

public class GetProductTypeQueryHandler : IRequestHandler<GetProductTypeQuery, ProductTypeVm>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public GetProductTypeQueryHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ProductTypeVm> Handle(GetProductTypeQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var productType = await _context.ProductTypes.Where(x => x.Id == request.ProductTypeId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if (productType == null)
            {
                throw new ObjectNotExistInDbException(request.ProductTypeId, "Product type");
            }

            return _mapper.Map<ProductTypeVm>(productType);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}