namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        public string CartId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public virtual Product Product { get; set; }

        public virtual Product Product1 { get; set; }
    }
}
