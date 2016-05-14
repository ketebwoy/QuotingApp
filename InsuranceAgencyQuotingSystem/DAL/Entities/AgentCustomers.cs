using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class AgentApplicants
    {
        [Key]
        [Column(Order = 0)]
        public int AgentId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ApplicantId { get; set; }
    }
}
