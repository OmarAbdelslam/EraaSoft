using Lecture_13.Data;

namespace Lecture_13.IRepositoryContracts
{
    public interface IProjectsContracts
    {
        void AddNewProject( Project project);

        IList<Project> AllProjects();

        void UpdateProjects(string project_Title);

        void DeletePRojects(string project_Title);
    }
}
