using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Departement
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> employees { get; set; }
    }
}
