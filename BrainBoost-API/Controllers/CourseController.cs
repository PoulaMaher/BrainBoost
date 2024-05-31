using BrainBoost_API.DTOs.Account;
using BrainBoost_API.Models;
using BrainBoost_API.Repositories.Inplementation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BrainBoost_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public readonly UserManager<ApplicationUser> UserManager;
        private readonly IUnitOfWork UnitOfWork;
        public CourseController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.UserManager = userManager;
            this.UnitOfWork = unitOfWork;
        }
        [HttpGet("GetCourses")]
        public async Task<IActionResult> GetCourses()
        {
            if (ModelState.IsValid)
            {
                List<Course> Courses = UnitOfWork.CourseRepository.GetAll().ToList();
                return Ok(Courses);
            }
            return BadRequest(ModelState);
        }
        [HttpPost("AddCourse")]
        public async Task<IActionResult> AddCourse(Course NewCourse)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.CourseRepository.add(NewCourse);
                UnitOfWork.save();
                return Ok(NewCourse);
            }
            return BadRequest(ModelState);
        }
    }
}
