namespace Lecture_13.Data.DBWork
{
    public class DataProject
    {
        public ICollection<Project> Projects { get; set; }

        public DataProject()
        {
            Projects = new List<Project>();
        }


    }
}
