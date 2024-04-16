using OKR.Data;
using OKR.Models;
using OKR.Repository.Interface;

namespace OKR.Repository.Implement
{
    public class TeamMemberRepository : MainRepository<TeamMember>, ITeamMemberRepository
    {
        public TeamMemberRepository(ApplicationDbContext db) : base(db)
        {
            
        }
    }
}
