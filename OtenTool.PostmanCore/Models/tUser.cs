using System.ComponentModel.DataAnnotations;

namespace OtenTool.PostmanCore.Models
{
    public class tUser : BaseEntity
    {
        [MaxLength(50, ErrorMessage = "Max Length is 50")]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "This attribute is required")]
        [MaxLength(16, ErrorMessage = "Max Length is 16")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "This attribute is required")]
        [MaxLength(100, ErrorMessage = "Max Length is 100")]
        public required string Mail { get; set; }
    }
}
