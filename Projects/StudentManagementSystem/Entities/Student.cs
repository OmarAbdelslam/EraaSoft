namespace Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int  Age { get; set; }

        public IList<Course> Courses { get; set; }




        public bool Enroll(Course course)
        {

        }

        public string PrintDetails()
        {
            return string.Empty;
        }
    }
}
