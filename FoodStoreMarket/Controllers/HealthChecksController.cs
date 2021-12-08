using FoodStoreMarket.Api.Controllers;
using FoodStoreMarket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodStoreMarket.Controllers
{
    [Route("api/hc")]
    public class HealthChecksController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Healthy";
        }
    }
}
