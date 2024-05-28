using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int? Rate { get; set; }

        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }
        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        [ForeignKey("Certificate")]
        public string CertificateId { get; set; }

        public Certificate Certificate { get; set; }
        public Teacher Teacher { get; set; }
        public Category Category { get; set; }



    }
}
