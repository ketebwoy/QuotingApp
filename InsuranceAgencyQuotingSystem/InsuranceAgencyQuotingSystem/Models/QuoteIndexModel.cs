using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceAgencyQuotingSystem.Models
{
    public class QuoteIndexModel
    {
        public List<Quote> Quotes { get; set; }
        public List<Agent> Agents { get; set; }
        public List<Applicant> Applicants { get; set; }
        public List<Policy> Policies { get; set; }



        public QuoteIndexModel()
        {
            this.Policies = new List<Policy>();
            this.Agents = new List<Agent>();
            this.Applicants = new List<Applicant>();
            this.Quotes = new List<Quote>();
        }
    }
}
