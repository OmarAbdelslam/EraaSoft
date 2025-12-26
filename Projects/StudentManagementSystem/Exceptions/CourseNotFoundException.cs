using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Exceptions
{
    public class CourseNotFoundException : Exception
    {
        public CourseNotFoundException() : base("Course wasn't found") { }
    }
}
