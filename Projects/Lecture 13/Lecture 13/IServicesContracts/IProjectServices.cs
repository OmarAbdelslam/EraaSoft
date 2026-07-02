using Lecture_13.Data;

namespace Lecture_13.IServicesContracts
{
    public interface IProjectServices
    {
        void Add(Project project);

        IList<Project> AllProjects();

        void Update(string project_Title);

        void Delete(string project_Title);

    }
}
