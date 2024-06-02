using System.ComponentModel.DataAnnotations;

namespace BrainBoost_API.DTOs.Enrollment
{
    public class EnrollmentDto
    {
        public int Id { get; set; }
        public bool IsActive => false;
        [Required(ErrorMessage = "Student ID is required")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Course ID is required")]
        public int CourseId { get; set; }
    }
}
