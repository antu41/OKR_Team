using OKR.Data;
using OKR.Models;
using OKR.Repository.Interface;

namespace OKR.Repository.Implement
{
    public class MilestoneSubTaskRepository : MainRepository<MilestoneSubTask>, IMilestoneSubTaskRepository
    {
        public MilestoneSubTaskRepository(ApplicationDbContext db) : base(db)
        {
            
        }
    }
}
