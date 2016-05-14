using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Enums
{
    public class Coverages
    {
        public Dictionary<int, string> BodilyInjuryLimits = new Dictionary<int, string>
        {
            {1,  "$10,000/$20,000(State Min) or less"},
            {2,  "$25,000/$50,000"},
            {3,  "$50,000/$100,000"},
            {4,  "$100,000/$300,000"},
            {5,  "$100,000/$300,000"}
        };


        public Dictionary<int, string> LiabilityLimits = new Dictionary<int, string>
        {
            {1, "No bodily injury/$10k property damage" },
            {2, "No bodily injury/$25k property damage" },
            {3, "No bodily injury/$50k property damage" },
            {4, "No bodily injury/$100k property damage" },
            {5, "$10k/$20k/$10k" },
            {6, "$10k/$20k/$25k" },
            {7, "$25k/$50k/$50k" },
            {8, "$50k/$100k/$25k" },
            {9, "Recommended $50k/$100k/$50k " },
            {10, "$50k/$100k/$100k" },
            {11, "$100k/$300k/$50k" },
            {12, "$100k/$300k/$100k" },
            {13, "$250k/$500k/$100k" }
        };

        public Dictionary<int, string> UninsuredMotoristBILimits = new Dictionary<int, string>
        {
            {0, "No Coverage"},
            {1,  "$10k/$20kw/non-stacked option"},
            {2,  "$25k/$50kw/non-stacked option "},
            {3,  "$10k/$20kw/stacked option "},
            {4,  "$25k/$50kw/stacked option"}
        };

        public Dictionary<int, string> PersonalInjuryProtectionLimits = new Dictionary<int, string>
        {
             {1, "$ 0 ded, basic work loss excluded no resident relatives" },
             {2, "$ 0 ded, basic work loss excluded resident relatives" },  
             {3, "$ 0 ded, basic work loss included no resident relatives" },  
             {4, "$ 0 ded, basic work loss included resident relatives" },  
             {5, "$ 0 ded, extended work loss excluded no resident relatives" },  
             {6, "$ 0 ded, extended work loss excluded resident relatives" },  
             {7, "$ 0 ded, extended work loss included no resident relatives" },  
             {8, "$ 0 ded, extended work loss included resident relatives" },  
             {9, "$ 250 ded, basic work loss excluded no resident relatives" },  
             {10, "$ 250 ded, basic work loss excluded resident relatives" },  
             {11, "$ 250 ded, basic work loss included no resident relatives" },  
             {12, "$ 250 ded, basic work loss included resident relatives" },  
             {13, "$ 250 ded, extended work loss excluded no resident relatives" },  
             {14, "$ 250 ded, extended work loss excluded resident relatives" },  
             {15, "$ 250 ded, extended work loss included no resident relatives" },  
             {16, "$ 250 ded, extended work loss included resident relatives" },  
             {17, "$ 500 ded, basic work loss excluded no resident relatives" },  
             {18, "$ 500 ded, basic work loss excluded resident relatives" },  
             {19, "$ 500 ded, basic work loss included no resident relatives" },  
             {20, "$ 500 ded, basic work loss included resident relatives" },  
             {21, "$ 500 ded, extended work loss excluded no resident relatives" },  
             {22, "$ 500 ded, extended work loss excluded resident relatives" },  
             {23, "$ 500 ded, extended work loss included no resident relatives" },  
             {24, "$ 500 ded, extended work loss included resident relatives" },  
             {25, "$ 1k ded, basic work loss excluded no resident relatives" },  
             {26, "Recommended $ 1k ded, basic work loss excluded resident relatives" },
             {27, "Current $ 1k ded, basic work loss included no resident relatives" },  
             {28, "$ 1k ded, basic work loss included resident relatives" },  
             {29, "$ 1k ded, extended work loss excluded no resident relatives" },  
             {30, "$ 1k ded, extended work loss excluded resident relatives" },  
             {31, "$ 1k ded, extended work loss included no resident relatives" },  
             {32, "$ 1k ded, extended work loss included resident relatives" }
        };

        public Dictionary<int, string> MedicalPaymentsLimits = new Dictionary<int, string>
        {
            {1, "No coverage" },
            {2, "Recommended $500 per person" },  
            {3, "$1k per person" },  
            {4, "$2k per person" },  
            {5, "$5k per person" },  
            {6, "$10k per person" }
        };


        public Dictionary<int, string> ComprehensiveLimits = new Dictionary<int, string>
        {
            { 1, "No coverage" },
            { 2, "$100 deductible" },  
            { 3, "$250 deductible" },
            { 4, "Recommended $500 deductible" }, 
            { 5, "$1k deductible" },
            { 6, "$2k deductible" }
        };


        public Dictionary<int, string> CollisionLimits = new Dictionary<int, string>
        {
            { 1, "No coverage" },
            { 2, "$100 deductible" },
            { 3, "$250 deductible" },
            { 4, "Recommended $500 deductible" },
            { 5, "$1k deductible" },
            { 6, "$2k deductible" }
        };


        public Dictionary<int, string> RentalLimits = new Dictionary<int, string>
        {
            { 1, "No coverage" },
            { 2, "Recommended $30 per day ($900 maximum)" },
            { 3, "$250 deductible" },
            { 4, "$40 per day ($1,200 maximum)" },
            { 5, "$50 per day ($1,500 maximum)" }
        };

        public Dictionary<bool, string> RoadsideCoverage = new Dictionary<bool, string>
        {
            { false, "(Recommended) No coverage" },
            { true, "Coverage Selected" }
        };

        public Dictionary<bool, string> GapCoverageLimits = new Dictionary<bool, string>
        {
            { false, "No coverage" },
            { true, "(Recommended) Coverage Selected" }
        };




        public enum MaritalStatus
        {
            Married = 1, 
            DomesticPartner = 2,
            Separated = 3, 
            Widowed = 4, 
            Divorced = 5, 
            
        }

        public enum CoverageTypes
        {
            Collision = 1,
            PersonalInjuryProtection = 2,
            Liability= 3,
            Comprehensive = 4, 
            EmergencyRoadsideS = 5, 
            Rental = 6,
            Gap = 7,
            Medical = 8,
            BodilyInjury = 9, 
            PropertyDamage = 10,
            UninsuredMotorists = 11,
            UnderinsuredMotorists = 12

        }

     
        public enum ApplicantRelationship
        {
            insured = 1,
            spouse = 2,
            dependent = 3
        }

        public enum DriverStatus
        {
            active = 1,
            deactivated = 2

        }

        public enum LicenseStatus
        {
            active = 1,
            deactivated = 2
        }

        public enum Suspended
        {
            never = 1,
            less3years = 1
        }

        public enum Revoked
        {
            never = 1,
            less3years = 1
        }

        public enum DriversCourse
        {
            safeDriver = 1,
            none = 2
        }
    }
}
