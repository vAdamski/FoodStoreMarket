using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Application.Sizes.Queries.GetSizeDetail;

public class GetSizeDetailQueryHandler : IRequestHandler<GetSizeDetailQuery, SizeDetailVm>
{
    private IFoodStoreMarketDbContext _context;
    private IMapper _mapper;

    public GetSizeDetailQueryHandler(IMapper mapper, IFoodStoreMarketDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<SizeDetailVm> Handle(GetSizeDetailQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var size = await _context.Sizes.Where(x => x.Id == request.SizeId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);

            if (size == null)
            {
                throw new Exception($"Size with Id = {request.SizeId} not found!");
            }

            var vm = _mapper.Map<SizeDetailVm>(size);

            return vm;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}