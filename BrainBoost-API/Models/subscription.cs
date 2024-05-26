using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost_API.Models
{
    public class subscription
    {
        public Guid Id { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }
        [ForeignKey("Plan")]
        public Guid PlanId { get; set; }

        // Additional properties
        public string? SubscribtionsStatus { get; set; }
        public string? TransactionNo { get; set; }
        public string? CheckUrl { get; set; }
        public string? orderNumber { get; set; }


        public Teacher? Teacher { get; set; }
        public Plan? Plan { get; set; }

    }
}
