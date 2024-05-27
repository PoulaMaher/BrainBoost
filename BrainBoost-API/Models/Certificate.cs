using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Certificate
    {
        public string Id { get; set; }
        public string Headline { get; set; }
        public string AppreciationParagraph { get; set; }

        [ForeignKey("Course")]
        public string CourseId { get; set; }

        public Course Course { get; set; }

    }
}
