using System.ComponentModel.DataAnnotations;

namespace OtenTool.PostmanCore.Models
{
    public class tRequestItem : BaseEntity
    {
        [Required(ErrorMessage = "This attribute is required")]
        public string Json { get; set; }

        [MaxLength(500, ErrorMessage = "Max Length is 500")]
        public string? Description { get; set; }
    }
}
