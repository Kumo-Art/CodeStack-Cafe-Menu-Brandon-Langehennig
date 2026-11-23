using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantServices _services;

        public RestaurantController(IRestaurantServices services)
        {
            _services = services;
        }

        [HttpGet("getbyid/{id}")]

        public async Task<ActionResult<Restaurant>> GetById(int id)
        {
            Restaurant? restaurant = await _services.GetByIdAsync(id);

            if(restaurant is null)
            {
                return NotFound();
            }

            return Ok(restaurant);
        }


        [HttpPost("addrestaurant")]

        public async Task<ActionResult<Restaurant>> AddAsync([FromBody] Restaurant restaurant)
        {
            Restaurant rest = await _services.AddAsync(restaurant);

            return CreatedAtAction(nameof(GetById), new {id = rest.Id}, rest);
        }
    }
}