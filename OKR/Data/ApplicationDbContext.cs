using Microsoft.EntityFrameworkCore;
using OKR.Models;

namespace OKR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<MilestoneTask> MilestoneTasks { get; set; }
        public DbSet<MilestoneSubTask> MilestoneSubTasks { get; set; }
    }
}
