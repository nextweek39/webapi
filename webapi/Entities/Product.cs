using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace webapi.Entities
{
    [Table("Product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        
        public string ProductCode { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }
        
        [Required]
        public int ProductQuantity { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}