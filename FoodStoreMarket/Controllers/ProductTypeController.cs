using System.Threading.Tasks;
using FoodStoreMarket.Application.ProductTypes.Commands.AddNewProductType;
using FoodStoreMarket.Application.ProductTypes.Queries.GetAllProductTypesInRestaurant;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreMarket.Api.Controllers;

[Route("api/productTypes")]
[EnableCors("MyAllowSecificOrigins")]
public class ProductTypeController : BaseController
{
    /// <summary>
    /// Get productTypes in restaurant
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetAllProductTypesInRestaurant(int id)
    {
        var vm = await Mediator.Send(new GetAllProductTypesInRestaurantQuery() { MenuId = id });

        return Ok(vm);
    }
    
    /// <summary>
    /// Add product type
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<ActionResult<int>> PostAsync([FromBody]AddNewProdcutTypeCommand prodcutTypeCommand)
    {
        var vm = prodcutTypeCommand;

        var id = await Mediator.Send(vm);

        if (id != null)
        {
            // Implement Created
            return Ok(id);
        }
        return NotFound();
    }
}