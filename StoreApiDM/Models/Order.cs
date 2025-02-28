﻿using System.ComponentModel.DataAnnotations;

namespace StoreApiDM.Models
{
    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }

        public Guid OrderGuid { get; set; }

        public DateTime? OrderDate { get; set; }
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public decimal? Total { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
