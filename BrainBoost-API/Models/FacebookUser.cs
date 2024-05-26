namespace BrainBoost_API.Models
{
    public class FacebookUser
    {
        public Guid Id { get; set; }
        public string FacebookUserId { get; set; }
        public Guid OriginalApplicationUserId { get; set; }


        //public ApplicationUser ApplicationUser { get; set;}
    }
}
