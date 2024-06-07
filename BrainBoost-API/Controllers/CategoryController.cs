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
        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            if (ModelState.IsValid)
            {
                List<Category> Categories = CategoryRepository.GetAll().ToList();
                return Ok(Categories);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            if (ModelState.IsValid)
            {
                Category category = CategoryRepository.Get(c => c.Id == id);
                return Ok(category);
            }
            return BadRequest(ModelState);
        }

    }
}
