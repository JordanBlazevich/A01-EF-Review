using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Key]
        public string TerritoryID { get; set; }
        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(50, ErrorMessage = "Territory descr. cannot be more than 50 characters long")]
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public virtual ICollection<Territory> Territories { get; set; } = new HashSet<Territory>(); //Nav prop
    }
}
