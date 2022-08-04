using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FoodStoreMarket.Application.ProductSpecifications.Commands.EditProductSpecification;

namespace FoodStoreMarket.Api.Controllers;

/// <summary>
/// End-point to manage products specifications in restaurant
/// </summary>
[Route("api/productSpecifications")]
[EnableCors("MyAllowSpecificOrigins")]
public class ProductSpecificationController : BaseController
{
    /// <summary>
    /// Update product specification
    /// </summary>
    /// <returns></returns>
    [HttpPatch]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> PatchAsync([FromBody] EditProductSpecificationCommand command)
    {
        if (command == null)
        {
            return NotFound();
        }

        var response = await Mediator.Send(command);

        if (response == false)
        {
            return NotFound();
        }

        return Ok();
    }
}