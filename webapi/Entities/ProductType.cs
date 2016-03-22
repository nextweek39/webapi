using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Entities
{
    [Table("ProductType")]
    public class ProductType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductTypeId { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Field must be at least 4 characters")]
        public string ProductTypeDescription { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}