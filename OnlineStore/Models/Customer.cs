namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(24)]
        public string First { get; set; }

        [Required]
        [StringLength(24)]
        public string Last { get; set; }

        [Required]
        [StringLength(16)]
        public string Login { get; set; }

        [Required]
        [StringLength(16)]
        public string Password { get; set; }

        [Required]
        [StringLength(45)]
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
