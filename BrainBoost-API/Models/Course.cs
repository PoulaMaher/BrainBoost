using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int? Rate { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("Certificate")]
        public int CertificateId { get; set; }

        public Certificate? Certificate { get; set; }
        public Teacher? Teacher { get; set; }
        public Category? Category { get; set; }
         


    }
}
