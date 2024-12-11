using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtenTool.PostmanCore.Models
{
    public class tTreeItem : BaseEntity
    {
        [Required(ErrorMessage = "This attribute is required")]
        [MaxLength(100, ErrorMessage = "Max Length is 100")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "This attribute is required")]
        public int ProjectItemId { get; set; }
        public int? ParentId { get; set; }
        public bool IsRequest { get; set; }
        public int? RequestItemId { get; set; }


        [ForeignKey(nameof(RequestItemId))]
        public virtual tRequestItem? t_RequestItem { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual tTreeItem? t_TreeItem { get; set; }

        [ForeignKey(nameof(ProjectItemId))]
        public virtual tProject? t_Project { get; set; }

    }
}
