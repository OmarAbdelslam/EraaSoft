using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        
        public int departementid { get; set; }
       
        public Departement departement { get; set; }
    }
}
