using BrainBoost_API.Models;

namespace BrainBoost_API.Repositories.Inplementation
{
    public class CourseRepository : Repository<Course> , ICourseRepository
    {
        private readonly ApplicationDbContext Context;
        public CourseRepository(ApplicationDbContext context) : base(context)
        {
            this.Context = context;
        }
    }
}
