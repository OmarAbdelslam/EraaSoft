using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Course
    {
        public int  CourseId { get; set; }

        public string Title { get; set; }

        public virtual Instructor Instructor { get; set; } = new Instructor();



        public string PrintDetails()
        {
            return $"{CourseId}\t{Title}\t{Instructor.InstructorId}\t{Instructor.Name
                }\t{Instructor.Specialization}";
        }

        public override string ToString()
        {
            return PrintDetails();
        }
    }
}
