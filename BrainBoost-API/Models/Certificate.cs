using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Certificate
    {
        public Guid Id { get; set; }
        public string Headline { get; set; }
        public string AppreciationParagraph { get; set; }

        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        public Course Course { get; set; }

    }
}
