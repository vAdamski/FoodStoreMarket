using System.Threading.Tasks;
using FoodStoreMarket.Application.ProductSizeSpecifications.Commands.AddSizeSpecificationToProduct;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreMarket.Api.Controllers;

/// <summary>
/// End-point to manage product sizes
/// </summary>
[Route("api/productSizeSpecifications")]
[EnableCors("MyAllowSpecificOrigins")]
public class ProductSizeSpecificationController : BaseController
{
    /// <summary>
    /// Add product size specification to product
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<ActionResult> PostAsync([FromBody]AddSizeSpecificationToProductCommand command)
    {
        if (command == null)
        {
            return BadRequest();
        }
            
        var response = await Mediator.Send(command);
            
        return Ok(response);
    }
}