using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Cors;
using System;
namespace FoodStoreMarket.Api.Controllers
{
	[Route("api/ingredients")]
	[EnableCors("MyAllowSecificOrigins")]
	public class IngredientsController : BaseController
	{
		public IngredientsController()
		{

		}
	}
}

