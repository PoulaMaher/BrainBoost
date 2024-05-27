using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Quiz
    {
        public string Id { get; set; }
        public int NumOfQuestions { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        [ForeignKey("Course")]
        public string CourseId { get; set; }

        public Course Course { get; set; }
        public List<Question> Questions { get; set; }

    }
}
