namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    //tinfo200:[2021-03-13-ktran20-dykstra2] - Create the Enrollment class 
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}