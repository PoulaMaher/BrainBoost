using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Boolean Type { get; set; }   // if zero -> True or False Question   , if one Multiple Choice Question

        [ForeignKey("TrueAnswer")]
        public Guid TrueAnswerId { get; set; }

        public Answer TrueAnswer { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
