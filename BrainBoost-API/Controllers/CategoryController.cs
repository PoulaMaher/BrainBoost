using BrainBoost_API.Models;
using BrainBoost_API.Repositories.Inplementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BrainBoost_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository CategoryRepository;
        public CategoryController(ICategoryRepository CategoryRepository)
        {
            this.CategoryRepository = CategoryRepository;
        }
        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategory()
        {
            if (ModelState.IsValid)
            {
                List<Category> Categories = CategoryRepository.GetAll().ToList();
                return Ok(Categories);
            }
            return BadRequest(ModelState);
        }

    }
}
