using System.ComponentModel.DataAnnotations;

namespace OKR.Models
{
    public class Project : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string ProjectName { get; set; } = string.Empty;
        public string? FilePath { get; set; } = string.Empty;
        public string? Description { get; set;} = string.Empty;
    }
}
