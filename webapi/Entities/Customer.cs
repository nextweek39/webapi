using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace webapi.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string CustFname { get; set; }

        [StringLength(50)]
        public string CustLname { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}