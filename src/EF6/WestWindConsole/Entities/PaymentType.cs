using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("PaymentTypes")]
    public class PaymentType
    {
        [Key]
        public int PaymentTypeID { get; set; }
        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(40, ErrorMessage = "Payment type descr. cannot be more than 40 characters long")]
        public string PaymentTypeDescription { get; set; }

        public virtual ICollection<PaymentType> PaymentTypes { get; set; } = new HashSet<PaymentType>(); //Nav prop
    }
}
