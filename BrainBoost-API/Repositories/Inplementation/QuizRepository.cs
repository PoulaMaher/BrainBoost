using BrainBoost_API.Models;

namespace BrainBoost_API.Repositories.Inplementation
{
    public class QuizRepository : Repository<Quiz> , IQuizRepository
    {
        private readonly ApplicationDbContext Context;
        public QuizRepository(ApplicationDbContext context) : base(context)
        {
            this.Context = context;
        }
    }
}
