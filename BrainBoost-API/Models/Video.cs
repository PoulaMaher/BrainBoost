using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class Video
    {
        public string Id { get; set; }
        public string Headline { get; set; }

        [ForeignKey("Course")]
        public string CrsId { get; set; }
        

        public Course Course { get; set; }
    }
}
