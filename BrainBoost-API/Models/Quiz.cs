using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public int NumOfQuestions { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        public Course Course { get; set; }
    }
}
