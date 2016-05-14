using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Quote
    {
        private const string RegExEmailPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        //@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        private const string RegExPhonePattern =
            @"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$";



        [Key]
        [ScaffoldColumn(false)]
        public int QuoteId { get; set; }

        
        public int AgentId { get; set; }

        
        public int VehicleId { get; set; }

        
        public int ApplicantId { get; set; }
        
        
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        
        public string City { get; set; }

        
        public string State { get; set; }

        
        public string ZipCode { get; set; }

        
        public int YearsAtAddress { get; set; }

        
        public int NumResidentsinHouehold { get; set; }

        
        public bool OtherVehiclesInHouseHold { get; set; }

        
        public int MonthsWithCurrentInsurance { get; set; }

        
        public string PriorInsuranceCompany { get; set; }
        
        
        public bool PriorInsuranceCompanyFlag { get; set; }

        public int LiabilityBIPDCoverage { get; set; }

        public int UninsuredMotoristBICoverage { get; set; }

        public int UnderinsuredMotoristBICoverage { get; set; }

        public int PersonalInjuryProtectionCoverage { get; set; }
        
        public int MedicalPaymentsCoverage { get; set; }             
        public bool ApplicantPageValid { get; set; }
       
        public bool ApplicantQuoteInfoPageValid { get; set; }

        
        public bool DriverPageValid { get; set; }

        
        public bool VehiclePageValid { get; set; }
            
        
        public bool IncidentPageValid { get; set; }

        
        public bool CoveragePageValid { get; set; }

        
        public bool RatePageValid { get; set; }

        
        public bool QuotePageValid { get; set; }

        
        public bool BuyPolicyPageValid { get; set; }


        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime CreatedDate { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime LastModifiedDate { get; set; }

    }
       
}


