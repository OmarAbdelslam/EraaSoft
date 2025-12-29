using Entities.DBWork;

namespace Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int  Age { get; set; }

        public IList<Course> Courses { get; set; } = new List<Course>();




        public bool Enroll(Course course)
        {
            try
            {
                Courses.Add(course);
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public string PrintDetails()
        {
            return $"{StudentId}\t{Name}\t{Age}";
        }

        public override string ToString()
        {
            return PrintDetails();
        }
    }
}
