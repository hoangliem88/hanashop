using System;
using System.ComponentModel.DataAnnotations;

namespace HanaShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { get; set; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
    }
}