namespace OKR.Models
{
    public class MilestoneSubTask : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime? EstimateTime { get; set; } = DateTime.UtcNow;
        public DateTime? DueDate { get; set; } = DateTime.UtcNow;
        public string AssigneeId { get; set; } = string.Empty;
        public TeamMember? Assignee { get; set; }
    }
}
