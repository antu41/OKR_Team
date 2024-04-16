using OKR.Data;
using OKR.Models;
using OKR.Repository.Interface;

namespace OKR.Repository.Implement
{
    public class MilestoneRepository : MainRepository<Milestone>, IMilestoneRepository
    {
        public MilestoneRepository(ApplicationDbContext db) : base(db)
        {
            
        }
    }
}
