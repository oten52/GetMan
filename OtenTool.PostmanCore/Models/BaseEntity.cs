using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtenTool.PostmanCore.Models
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CreatedId { get; set; }
        public bool IsDeleted { get; set; } = false;

        [ForeignKey(nameof(CreatedId))]
        public virtual tUser CreatedUser { get; set; }
    }
}
