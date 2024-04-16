using OKR.Data;
using OKR.Models;
using OKR.Repository.Interface;

namespace OKR.Repository.Implement
{
    public class MilestoneTaskRepository : MainRepository<MilestoneTask>, IMilestoneTaskRepository
    {
        public MilestoneTaskRepository(ApplicationDbContext db) : base(db)
        {
            
        }
    }
}
