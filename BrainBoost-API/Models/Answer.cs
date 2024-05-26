using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Answer
    {
        public Guid Id { get; set; }
        public string Content { get; set; }

        [ForeignKey("Question")]
        public Guid QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
