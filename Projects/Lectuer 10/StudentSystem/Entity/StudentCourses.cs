using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Entity
{
    internal class StudentCourses
    {
        public int FK_StudentID { get; set; }
        public Student student { get; set; }
        public int FK_CourseID { get; set; }
        public Course course { get; set; }
    }
}
