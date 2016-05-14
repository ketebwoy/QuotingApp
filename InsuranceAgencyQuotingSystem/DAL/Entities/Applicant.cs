using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Applicant
    {
        private const string RegExEmailPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        private const string RegExPhonePattern =
            @"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$";


        [Key]
        [ScaffoldColumn(false)]
        public int ApplicantId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(2)]
        public string MI { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        public System.DateTime DOB { get; set; }

        [Required, RegularExpression(RegExEmailPattern, ErrorMessage = "Email Format must be userName@Domain.server ex: wellbeingsmsadmin@wellbeingsms.com")]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Required, RegularExpression(RegExPhonePattern, ErrorMessage = "Phone Number format must be ###-###-####")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required, RegularExpression(RegExPhonePattern, ErrorMessage = "Phone Number format must be ###-###-####")]
        [StringLength(20)]
        public string CellNumber { get; set; }

      
        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime CreatedDate { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime LastModifiedDate { get; set; }

    }
}
