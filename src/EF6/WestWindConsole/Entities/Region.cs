using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Regions")]
    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(50, ErrorMessage = "Region descr. cannot be more than 50 characters long")]
        public string RegionDescription { get; set; }

        public virtual ICollection<Region> Regions { get; set; } = new HashSet<Region>(); //Nav prop
    }
}
