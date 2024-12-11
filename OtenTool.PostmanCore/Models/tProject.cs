using System.ComponentModel.DataAnnotations;

namespace OtenTool.PostmanCore.Models
{
    public class tProject : BaseEntity
    {
        [Required(ErrorMessage = "This attribute is required")]
        [MaxLength(100, ErrorMessage = "Max Length is 100")]
        public required string ProjectName { get; set; }

        public virtual ICollection<tTreeItem>? t_TreeItems { get; set; }
    }
}
