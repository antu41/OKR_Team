using OKR.Data;
using OKR.Models;
using OKR.Repository.Interface;

namespace OKR.Repository.Implement
{
    public class ProjectRepository : MainRepository<Project>, IProjectRepositroy
    {
        public ProjectRepository(ApplicationDbContext db) : base(db)
        {
            
        }
    }
}
