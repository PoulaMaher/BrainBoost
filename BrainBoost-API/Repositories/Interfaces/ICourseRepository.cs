using BrainBoost_API.DTOs.Course;
using BrainBoost_API.Models;

namespace BrainBoost_API.Repositories.Inplementation
{
    public interface ICourseRepository : IRepository<Course>
    {
        CourseDetails getCrsDetails(Course crs,List<Review> review);
        IEnumerable<Course> GetFilteredCourses(CourseFilterationDto filter, string? includeProps);
        List<Course> SearchCourses(string searchString, string? includeProps);
    }
}
