using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HanaShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [Key]
        public int ProducID { set; get; }

        public int? Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProducID")]
        public virtual Product Product { set; get; }
    }
}