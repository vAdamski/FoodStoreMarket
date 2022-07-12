using System.Threading.Tasks;
using FoodStoreMarket.Application.ProductTypes.Commands.AddNewProductType;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreMarket.Api.Controllers;

[Route("api/productTypes")]
[EnableCors("MyAllowSecificOrigins")]
public class ProductTypeController : BaseController
{
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