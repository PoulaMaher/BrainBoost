using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Answer
    {
        public string Id { get; set; }
        public string Content { get; set; }

        [ForeignKey("Question")]
        public string? QuestionId { get; set; }

        public Question? Question { get; set; }
    }
}
