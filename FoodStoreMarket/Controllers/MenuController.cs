using System.Threading.Tasks;
using FoodStoreMarket.Application.Menus.Queries.GetProductsInRestaurant;
using FoodStoreMarket.Application.Products.Queries.GetProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreMarket.Api.Controllers;

/// <summary>
/// End-point to menage menu in restaurant
/// </summary>
[Route("api/menu")]
[AllowAnonymous]
public class MenuController : BaseController
{
    /// <summary>
    /// Get restaurant menu by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetRestaurantMenuById(int id)
    {
        var vm = await Mediator.Send(new GetMenuInRestaurantQuery() { RestaurantId = id });

        if (vm == null)
        {
            return NotFound();
        }

        return Ok(vm);
    }
    
}