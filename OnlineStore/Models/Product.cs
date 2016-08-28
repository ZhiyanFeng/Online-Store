namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Carts1 = new HashSet<Cart>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(128)]
        public string PhotoUrl { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<Cart> Carts1 { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
