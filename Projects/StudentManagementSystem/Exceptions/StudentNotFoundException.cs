using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException() : base("Student wasn't found.") 
        {
        }
    }
}
