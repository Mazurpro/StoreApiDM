﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StoreApiDM.Models
{
    public partial class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public Guid OrderDetailGuid { get; set; }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Count { get; set; }
        public decimal? UnitPrice { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
