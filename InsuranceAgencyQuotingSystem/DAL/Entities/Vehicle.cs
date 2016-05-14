using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Vehicle
    {
        [Key]
        [ScaffoldColumn(false)]
        public int VehicleId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public string Detail { get; set; }

        public Double CostNew { get; set; }

        public string DriveTrainWheels { get; set; }

        public Titled Titled { get; set; }

        public OwnedLeased OwnedLeased { get; set; }

        public int YearsOwnedLeased { get; set; }

        public bool GaragedElseWhere { get; set; }

        public string GaragingAddress1 { get; set; }

        public string GaragingAddress2 { get; set; }

        public string GaragingCity { get; set; }

        public string GaragingZipCode { get; set; }

        public string GaragingState { get; set; }

        public string MilesToWorkSchool { get; set; }

        public string AnnualMileage { get; set; }

        public VehicleUsuage Usage { get; set; }
               
        public bool FarmUse { get; set; }

        public int QuoteId { get; set; }

        public int DriverId { get; set; }

        public int ComprehensiveCoverage { get; set; }

        public int CollisionCoverage { get; set; }

        public int RentalCoverage { get; set; }

        public bool RoadSideCoverage { get; set; }

        public bool GapCoverage { get; set; }




        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime CreatedDate { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public System.DateTime LastModifiedDate { get; set; }

    }

    public enum VehicleBodyStyle
    {
        Sedan = 1,
        Coupe = 2,
        SUV = 3
    }

    public enum AntiTheft
    {
        alarm = 1,
        vehicleRecovery = 2,
        catProgram = 3,
        vinEtching = 4,
        lockingdevice = 5,
        other = 6,
        activeDisabling = 7,
        passiveDisabling = 8,
        none = 9
    }

    public enum Titled
    {
        insured = 1
    }

    public enum OwnedLeased
    {
        owned = 1,
        leased = 2,

    }

    public enum VehicleUsuage
    {
        Pleasure = 1,
        Business = 2, 
        School = 3,
        Senior = 4
    }


}
