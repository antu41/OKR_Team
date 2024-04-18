using System.ComponentModel.DataAnnotations;

namespace OKR.Models.ViewModels
{
    public class MilestoneViewModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        public List<MilestoneTaskViewModel> MilestoneTasks { get; set; }
    }

    public class MilestoneTaskViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public List<MilestoneSubTaskViewModel> MilestoneSubTasks { get; set; }
    }

    public class MilestoneSubTaskViewModel
    {
        [Required]
        public string Name { get; set; }
    }



        //public string? AssigneeId { get; set; } = string.Empty;
      //  public string? ProjectId { get; set; } = string.Empty;
      //  public string? TaskName { get; set; } = string.Empty;
        //public Priority? Priority { get; set; }
        //public Dependency? Dependency { get; set; }
        //public string? FilePath { get; set; } = string.Empty;
        //public string? Tag { get; set; } = string.Empty;

       // public string? MilestoneId { get; set; } = string.Empty;
       // public string? SubTaskName { get; set; } = string.Empty;
        //public bool? IsCompleted { get; set; }
      //  public string?  MilestoneTaskId { get; set; } = string.Empty;

    
}