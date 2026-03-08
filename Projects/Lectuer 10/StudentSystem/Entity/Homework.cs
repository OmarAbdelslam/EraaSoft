using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Entity
{
    internal class Homework
    {
        public int HomeworkID { get; set; }
        public string  Content { get; set; }
        public ContentType MyProperty { get; set; }
        public DateTime SubmissionTime { get; set; }

        [ForeignKey(nameof(Student.HomeworkSubmissions))]
        public int FK_StudentID { get; set; }
        public Student StudentID { get; set; }

        [ForeignKey(nameof(Course.HomeworkSubmissions))]
        public int FK_CourseID { get; set; }
        public Course CourseID { get; set; }
    }

}
