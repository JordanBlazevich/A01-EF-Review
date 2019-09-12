using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Addresses")]
    class Address
    {
        [Key]
        public int AddressID { get; set; }
        [Column("Address")] //Maps to the DB column 'Address'
        public string StreetAddress { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(15, ErrorMessage = "City name cannot be more than 15 characters long")]
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(15, ErrorMessage = "Country Name cannot be more than 15 characters long")]
        public string Country { get; set; }

        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>(); //Nav prop
    }
}
