using System.ComponentModel.DataAnnotations;

namespace OKR.Models.ViewModels
{
    public class ProjectCreateViewModel
    {
        [Required]
        [StringLength(50)]
        public string ProjectName { get; set; } = string.Empty;
        public IFormFile File { get; set; }
        public string? Description { get; set; } = string.Empty;
        [Required]
        public string ProjectId { get; set; } = string.Empty;
        [Required]
        public List<string> AssigneeId { get; set; } = new List<string>();

    }
}
