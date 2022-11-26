using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notification_AWS.Models
{
    [Table("dbo.pessoas")]
    public class Files
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Filename { get; set; }
        public long Filesize { get; set; }
        public DateTime Last_modified { get; set; }
    }
}