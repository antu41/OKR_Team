namespace OKR.Models
{
    public class MilestoneSubTask : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        //public DateTime? EstimateTime { get; set; } = DateTime.UtcNow;
        //public DateTime? DueDate { get; set; } = DateTime.UtcNow;
        //public string? AssigneeId { get; set; } = string.Empty;
        //public TeamMember? Assignee { get; set; }
        //public bool? IsCompleted { get; set; }
        public string? MilestoneTaskId { get; set; } = string.Empty;
        public MilestoneTask? MilestoneTask { get; set; }
    }
}
