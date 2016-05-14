using DAL.Entities;
using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceAgencyQuotingSystem.Models
{
    public class CreateQuoteModel
    {
        public Quote Quote { get; set; }
        public Agent Agent { get; set; }
        public Applicant Applicant { get; set; }
        public Vehicle Vehicle { get; set; }
        public Driver Driver { get; set; }
        public Incident Incident { get; set; }
        public List<Applicant> Applicants { get; set; }
        public Policy Policy { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Incident> Incidents { get; set; }
        public Coverages Coverages { get; set; }
       

        public CreateQuoteModel()
        {
            this.Applicant = new Applicant(); 
            this.Policy = new Policy();
            this.Agent = new Agent();
            this.Vehicle = new Vehicle();
            this.Driver = new Driver();
            this.Incident = new Incident(); 
            this.Applicants = new List<Applicant>();
            this.Quote = new Quote();
            this.Drivers = new List<Driver>();
            this.Vehicles = new List<Vehicle>();
            this.Incidents = new List<Incident>();
            this.Coverages = new Coverages();

            this.Quote.ApplicantPageValid = false;
            this.Quote.ApplicantQuoteInfoPageValid = false;
            this.Quote.BuyPolicyPageValid = false;
            this.Quote.CoveragePageValid = false;
            this.Quote.DriverPageValid = false;
            this.Quote.IncidentPageValid = false;
            this.Quote.QuotePageValid = false;
            this.Quote.RatePageValid = false;
            this.Quote.VehiclePageValid = false;
        }
    }
}