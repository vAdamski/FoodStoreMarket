using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Indegriments.Commands.CreateIndegriment
{
    public class CreateIndegrimentHandler : IRequestHandler<CreateIndegrimentCommand, int>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public CreateIndegrimentHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext,
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateIndegrimentCommand request, CancellationToken cancellationToken)
        {
            var indegrimentToAdd = _mapper.Map<Indegriment>(request);

            _context.Indegriments.Add(indegrimentToAdd);

            await _context.SaveChangesAsync(cancellationToken);

            return indegrimentToAdd.Id;
        }
    }
}

