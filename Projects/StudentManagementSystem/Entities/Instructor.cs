using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }


        public string PrintDetails()
        {
            return string.Empty;
        }
    }
}
