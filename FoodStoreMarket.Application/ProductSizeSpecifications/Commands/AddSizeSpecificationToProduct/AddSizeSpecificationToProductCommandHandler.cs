using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct;

public class AddSizeSpecificationToProductCommandHandler : IRequestHandler<AddSizeSpecificationToProductCommand, int>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public AddSizeSpecificationToProductCommandHandler(IFoodStoreMarketDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(AddSizeSpecificationToProductCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var product = await _context.Products
                .Where(x => x.Id == request.ProductId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null)
            {
                throw new ObjectNotExistInDbException(request.ProductId, "Product");
            }

            if (await _context.Sizes.Where(x => x.Id == request.SizeId && x.StatusId == 1)
                    .FirstOrDefaultAsync(cancellationToken) == null)
            {
                throw new ObjectNotExistInDbException(request.SizeId, "Size");
            }

            var sizeSpec = _mapper.Map<ProductSizeSpecification>(request);
            sizeSpec.ProductSpecificationId = (int)product.ProductSpecificationId;

            await _context.ProductSizeSpecifications.AddAsync(sizeSpec,cancellationToken);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return sizeSpec.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}