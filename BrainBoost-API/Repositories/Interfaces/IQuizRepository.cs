using BrainBoost_API.DTOs.Quiz;
using BrainBoost_API.Models;

namespace BrainBoost_API.Repositories.Inplementation
{
    public interface IQuizRepository : IRepository<Quiz>
    {
<<<<<<< HEAD
        public QuizDTO getCrsQuiz(Quiz quiz, IEnumerable<Question> question,bool IsTaken);
       
=======
        public QuizDTO getCrsQuiz(Quiz quiz, IEnumerable<Question> question);
>>>>>>> 756686e55193e3b79a7e14c5469c3d8f252f42cd
    }
}
