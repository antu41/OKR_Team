using System.ComponentModel.DataAnnotations;

namespace OKR.Models.ViewModels
{
    public class MilestoneViewModel
    {
        public Milestone Milestone { get; set; }
        public List<MilestoneTask> MilestoneTasks { get; set; }
        public List<MilestoneSubTask> MilestoneSubTasks { get; set; }

        public MilestoneViewModel()
        {
            Milestone = new Milestone();
            MilestoneTasks = new List<MilestoneTask>();
            MilestoneSubTasks = new List<MilestoneSubTask>();
        }
    }
}