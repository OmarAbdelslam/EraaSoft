using System.ComponentModel.DataAnnotations;

namespace Lecture_13.Data
{
    public class Project
    {
        [Key]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public string File { get; set; }

    }
}
