using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Review
    {
        public string Id { get; set; }
        public string? Content { get; set; }
        public int Rate { get; set; }

        [ForeignKey("Student")]
        public string StudentId { get; set; }
        [ForeignKey("Course")]
        public string CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }


    }
}
