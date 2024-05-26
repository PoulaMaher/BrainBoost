using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Video
    {
        public Guid Id { get; set; }
        public string Headline { get; set; }

        [ForeignKey("Course")]
        public Guid CrsId { get; set; }
        

        public Course Course { get; set; }
    }
}
