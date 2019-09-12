using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(40, ErrorMessage = "Company Name cannot be more than 40 characters long")]
        public string CompanyName { get; set; }
        [Required] 
        [StringLength(40, ErrorMessage = "Contact Name cannot be more than 40 characters long")]
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Contact email cannot be more than 50 characters long")]
        public string ContactEmail { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "Address ID cannot be more than 60 characters long")]
        public string AddressID { get; set; }
        [Required]
        [StringLength(24, ErrorMessage = "Phone number cannot be more than 40 characters long")]
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>(); //Nav prop
    }
}
