using System.ComponentModel.DataAnnotations;

namespace OKR.Models
{
    public class Employee : BaseModel
    {
        [Required]
        public string EmpName { get; set; } = string.Empty;
        public string? Designation { get; set; }
    }
}
