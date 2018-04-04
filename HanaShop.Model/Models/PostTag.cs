using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HanaShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }

        [Key]
        [MaxLength(50)]
        public int TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}