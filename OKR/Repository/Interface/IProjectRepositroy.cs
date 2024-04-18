using OKR.Models;

namespace OKR.Repository.Interface
{
    public interface IProjectRepositroy : IMainRepository<Project>
    {
        List<Project> GetProjectDetails(string id);
    }
}
