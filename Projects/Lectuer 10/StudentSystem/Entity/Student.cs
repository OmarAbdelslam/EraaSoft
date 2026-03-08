using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Entity
{
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  StudentID { get; set; }
        public DateTime? Birthdate { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public uint PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; } = DateTime.Now;

        public ICollection<StudentCourses> studentCourses { get; set; }

        public ICollection<Homework> HomeworkSubmissions { get; set; }
    }
}
