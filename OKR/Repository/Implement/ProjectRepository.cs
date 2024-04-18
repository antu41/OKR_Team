using Microsoft.EntityFrameworkCore;
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

        public List<Project> GetProjectDetails(string id)
        {
            // Include related entities (Milestones and their MilestoneTasks)
            return db.Projects
                     .Include(p => p.Milestones)
                         .ThenInclude(m => m.MilestoneTasks)
                     .Where(x => x.Id == id)
                     .ToList();
        }
    }
}
