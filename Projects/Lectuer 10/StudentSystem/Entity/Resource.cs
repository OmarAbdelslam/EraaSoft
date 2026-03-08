using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Entity
{
    internal class Resource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResourseID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [EmailAddress]
        public string URL { get; set; }
        public ResourceTypes MyProperty { get; set; }

        [ForeignKey(nameof(Course.Resources))]
        public int FK_CourseID { get; set; }
        public Course Course { get; set; }

    }
}
