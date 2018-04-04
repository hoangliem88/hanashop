using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HanaShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string CustomerMobile { set; get; }

        [MaxLength(500)]
        public string CustomerMessage { set; get; }

        public DateTime? CreateDate { set; get; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string CreateBy { set; get; }

        [MaxLength(256)]
        public string PamentMethod { set; get; }


        [MaxLength(256)]
        public string PamentStatus { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }

    }
}
