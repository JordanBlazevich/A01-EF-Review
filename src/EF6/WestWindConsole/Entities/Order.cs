using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int SalesRepID { get; set; }
        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(5, ErrorMessage = "Cust ID cannot be more than 5 characters long")]
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public decimal? Frieght { get; set; }
        [Required]
        public bool Shipped { get; set; }
        [StringLength(40, ErrorMessage = "Shipper name cannot be more than 40 characters long")]
        public string ShipName { get; set; }
        public int ShipAddressID { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>(); //Nav prop
    }
}
