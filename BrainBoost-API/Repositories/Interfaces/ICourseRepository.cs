using BrainBoost_API.DTOs.Course;
using BrainBoost_API.Models;

namespace BrainBoost_API.Repositories.Inplementation
{
    public interface ICourseRepository : IRepository<Course>
    {
        CourseDetails getCrsDetails(Course crs,List<Review> review);
    }
}
