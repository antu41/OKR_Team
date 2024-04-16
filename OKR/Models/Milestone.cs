using System.ComponentModel.DataAnnotations;

namespace OKR.Models
{
    public class Milestone : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;

        public string AssigneeId { get; set; } = string.Empty;
        public TeamMember? Assignee { get; set; }
        public ICollection<MilestoneTask> MilestoneTasks { get; set; } = new List<MilestoneTask>();
        public string ProjectId { get; set; } = string.Empty;
        public Project? Project { get; set; }
    }
}
