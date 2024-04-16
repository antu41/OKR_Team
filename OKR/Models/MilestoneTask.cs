namespace OKR.Models
{
    public class MilestoneTask : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime? EstimateTime { get; set; } = DateTime.UtcNow;
        public DateTime? DueDate { get; set; } = DateTime.UtcNow;
        public Priority? Priority { get; set; }
        public Dependency? Dependency { get; set; }
        public string? FilePath { get; set; } = string.Empty;
        public string? Tag { get; set; } = string.Empty ;
        public string AssigneeId { get; set; } = string.Empty;
        public TeamMember? Assignee { get; set; }
         
    }
    public enum Priority 
    {
        High,
        Medium,
        Low
    }
    public enum Dependency
    {
        Wireframing
    }

}
