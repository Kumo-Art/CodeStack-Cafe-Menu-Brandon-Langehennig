using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesServices _services;

        public CategoriesController(ICategoriesServices services)
        {
            _services = services;
        }

        [HttpGet]

        public async Task<ActionResult<List<Categories>>> GetAll()
        {
            return Ok(await _services.GetAllAsync());
        }

        [HttpGet("getbyid/{id}")]

        public async Task<ActionResult<Categories>> GetById(int id)
        {
            Categories? category = await _services.GetByIdAsync(id);

            if(category is null)
            {
                return NotFound();
            }

            return Ok(category);
        }


        [HttpPost("addcategory")]

        public async Task<ActionResult<Categories>> AddAsync([FromBody] Categories category)
        {
            Categories cat = await _services.AddAsync(category);

            return CreatedAtAction(nameof(GetById), new {id = cat.Id}, cat);
        }
    }
}