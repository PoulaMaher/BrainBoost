using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Enrollment
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("Student")]
        public string StudentId { get; set; }
        [ForeignKey("Course")]
        public string CourseId { get; set; }

        // Additional properties
        public string? SubscribtionsStatus { get; set; }
        public string? TransactionNo { get; set; }
        public string? CheckUrl { get; set; }
        public string? orderNumber { get; set; }


        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
