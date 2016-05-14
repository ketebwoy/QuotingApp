using System.Data.Entity;
using DAL.Entities; 

namespace DAL.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("InsuranceAgencyDB") { }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<AgentApplicants> AgentApplicants { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Incident> Incidents { get; set; }
       // public DbSet<Coverage> Coverages { get; set; }
        //public DbSet<SMSIncoming> SMSIncomings { get; set; }
        //public DbSet<AutoResponder> AutoResponders { get; set; }
        //public DbSet<Triage> Triages { get; set; }
        //public DbSet<TriageFollowUp> TriageFollowUp { get; set; }
        //public DbSet<ContactsCampaigns> ContactsCamapigns { get; set; }
        //public DbSet<ContactsGroup> ContactsGroups { get; set; }
        //public DbSet<UserDefaultGroup> UserGroups { get; set; }
        //public DbSet<Email> Emails { get; set; }
        //public DbSet<CampaignTemplate> CampaignTemplates { get; set; }
        //public DbSet<ProcedureTemplate> ProcedureTemplates { get; set; }
        //public DbSet<TriageTemplate> TriageTemplates { get; set; }
        //public DbSet<FollowUpTemplate> FollowUpTemplate { get; set; }
        //public DbSet<ChatMessage> ChatMessages { get; set; }
        //public DbSet<Voice> VoiceCalls { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
