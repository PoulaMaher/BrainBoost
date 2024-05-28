using BrainBoost_API.Models;
using BrainBoost_API.Repositories.Interfaces;

namespace BrainBoost_API.Repositories.Inplementation
{
    public class TeacherRepository : Repository<Teacher> , ITeacherRepository
    {
        private readonly ApplicationDbContext Context;
        public TeacherRepository(ApplicationDbContext context) : base(context)
        {
            this.Context = context;
        }
    }
        
}
