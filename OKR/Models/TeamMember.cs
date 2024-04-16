using System.ComponentModel.DataAnnotations;

namespace OKR.Models
{
    public class TeamMember : BaseModel
    {
        [Required]
        public string ProjectId { get; set; } = string.Empty;
        public Project? Project { get; set; }
        [Required]
        public string AssigneeId { get; set; } = string.Empty;
        public Employee? Assignee { get; set; }

    }
}
