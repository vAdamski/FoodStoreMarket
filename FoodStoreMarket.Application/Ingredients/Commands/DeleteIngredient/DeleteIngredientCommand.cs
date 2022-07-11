using System;
using MediatR;

namespace FoodStoreMarket.Application.Ingredients.Commands.DeleteIngredient
{
	public class DeleteIngredientCommand : IRequest
	{
        public int IngredientIdToDelete { get; set; }
    }
}

