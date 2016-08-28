namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public TimeSpan OrderTime { get; set; }

        public float Total { get; set; }

        [Required]
        [StringLength(16)]
        public string CreditCardNumber { get; set; }

        public int CreditCardMonth { get; set; }

        public int CreditCardYear { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
