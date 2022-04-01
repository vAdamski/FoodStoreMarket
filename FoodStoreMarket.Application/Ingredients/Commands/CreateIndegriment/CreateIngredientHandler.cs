using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using MediatR;

namespace FoodStoreMarket.Application.Indegriments.Commands.CreateIndegriment
{
    public class CreateIngredientHandler : IRequestHandler<CreateIngredientCommand, int>
    {
        private readonly IFoodStoreMarketDbContext _context;
        private IMapper _mapper;

        public CreateIngredientHandler(
            IFoodStoreMarketDbContext foodStoreMarketDbContext,
            IMapper mapper)
        {
            _context = foodStoreMarketDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateIngredientCommand request, CancellationToken cancellationToken)
        {
            var indegrimentToAdd = _mapper.Map<Ingredient>(request);

            _context.Ingredients.Add(indegrimentToAdd);

            await _context.SaveChangesAsync(cancellationToken);

            return indegrimentToAdd.Id;
        }
    }
}

