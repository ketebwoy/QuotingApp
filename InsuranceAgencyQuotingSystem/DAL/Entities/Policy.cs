using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Policy
    {
        [Required]
        public int PolicyId { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime CreatedDate { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime LastModifiedDate { get; set; }


    }
}
