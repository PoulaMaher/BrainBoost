namespace BrainBoost_API.Models
{
    public class Student
    {

        public int? NumOfCrsEnrolled { get; set; }
        public int? NumOfCertificates { get; set; }
        public int? NumOfCrsSaved { get; set; }
        public string PictureUrl { get; set; }



        public List<Teacher>? FollowedTeachers { get; set; }
        public List<Course>? EnrolledCrs { get; set; }
        public List<Course>? SavedCrs { get; set; }
        public List<Certificate>? Certificates { get; set; }

    }
}
