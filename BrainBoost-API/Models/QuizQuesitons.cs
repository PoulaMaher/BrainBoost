using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class QuizQuesitons
    {
        [ForeignKey("Quiz")]
        public string QuizId { get; set; }
        [ForeignKey("Question")]
        public string QuestionId { get; set; }

        public Question Question { get; set; }
        public Quiz Quiz { get; set; }
    }
}
