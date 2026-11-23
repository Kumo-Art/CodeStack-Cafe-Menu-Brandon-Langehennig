using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsServices _services;

        public ItemsController(IItemsServices services)
        {
            _services = services;
        }

        [HttpGet]

        public async Task<ActionResult<List<Items>>> GetAll()
        {
            return Ok(await _services.GetAllAsync());
        }

        [HttpGet("getbyid/{id}")]

        public async Task<ActionResult<Items>> GetById(int id)
        {
            Items? item = await _services.GetByIdAsync(id);

            if(item is null)
            {
                return NotFound();
            }

            return Ok(item);
        }


        [HttpPost("additem")]

        public async Task<ActionResult<Items>> AddAsync([FromBody] Items items)
        {
            Items item = await _services.AddAsync(items);

            return CreatedAtAction(nameof(GetById), new {id = item.Id}, item);
        }
    }
}