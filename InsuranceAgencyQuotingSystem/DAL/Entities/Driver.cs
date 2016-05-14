using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Driver
    {
        [Key]
        [ScaffoldColumn(false)]
        public int DriverId { get; set; }

        [Required]
        public bool CoApplicantFlag { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(30)]
        public string MiddleInit { get; set; }

        [Required]
        [StringLength(30)]
        public string DateOfBirth { get; set; }

        [Required]
        [StringLength(30)]
        public string Gender { get; set; }

        [Required]
        public int AgeFirstLicensed { get; set; }

        [Required]
        [StringLength(30)]
        public string DriversLicenseNumber { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Occupation { get; set; }

        [Required]
        [StringLength(30)]
        public string EducationLevel { get; set; }

        [Required]
        public bool CriminalRecord { get; set; }

        [Required]
        public bool CancelledNonRenew { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime CreatedDate { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime LastModifiedDate { get; set; }


    }

   
}
