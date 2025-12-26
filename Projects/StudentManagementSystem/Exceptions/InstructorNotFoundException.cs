using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Exceptions
{
    public class InstructorNotFoundException : Exception
    {
        public InstructorNotFoundException() : base("Instructor wasn't found") { }
    }
}
