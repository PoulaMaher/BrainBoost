using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string AppreciationParagraph { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public Course? Course { get; set; }
        public Student? Student { get; set; }

    }
}
