using BrainBoost_API.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Question
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public QuestionType Type { get; set; }   // if zero -> True or False Question   , if one Multiple Choice Question
        public int Degree { get; set; }

        [ForeignKey("TrueAnswer")]
        public string TrueAnswerId { get; set; }

        public Answer TrueAnswer { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }
}
