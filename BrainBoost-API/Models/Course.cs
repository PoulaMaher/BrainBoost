using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        [ForeignKey("Certificate")]
        public Guid CertificateId { get; set; }

        public Certificate Certificate { get; set; }
        public Teacher Teacher { get; set; }
        public Category Category { get; set; }



    }
}
