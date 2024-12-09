using System.ComponentModel.DataAnnotations.Schema;

namespace OtenTool.PostmanCore.Models
{
    public class tProjectUserMap : BaseEntity
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual tUser? t_User { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public virtual tProject? tProject { get; set; }
    }
}
