using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Incident
    {
        [Key]
        [ScaffoldColumn(false)]
        public int IncidentId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [StringLength(30)]
        public string Cost { get; set; }

        [Required]
        [StringLength(30)]
        public string TimeFrame { get; set; }

        [Required]
        [StringLength(30)]
        public string DriverId { get; set; }

        [Required]
        public bool AtFault { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime CreatedDate { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime LastModifiedDate { get; set; }



    }
}
