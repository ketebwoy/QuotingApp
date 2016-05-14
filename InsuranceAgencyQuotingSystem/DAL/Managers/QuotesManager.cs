using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL.Managers
{
    public class QuotesManager
    {



        private DataContext _ctx = new DataContext();
        private DataManager _ctxFunctins = DataManager.Instance;


        public Quote GetQuoteById(int quoteId)
        {
            try
            {
                return _ctx.Quotes.First(p => p. QuoteId == quoteId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Quote " + quoteId + " " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public List<Quote> GetAllQuotes()
        {
            try
            {
                return _ctx.Quotes.ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Quotes " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public int AddQuote(Quote eQuote)
        {

            try
            {

                eQuote.CreatedDate = DateTime.Now;
                eQuote.LastModifiedDate = DateTime.Now;

                using (var context = new DataContext())
                {
                    context.Quotes.Add(eQuote);
                    context.SaveChanges();
                }
                return eQuote.QuoteId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured adding a Quote" + ex);
                //Console.WriteLine("An Error occured adding a Quote" + System.Environment.NewLine + ex);
                return -1;
            }
        }

        public void Update(Quote eQuote)
        {
            try
            {
                var updev = _ctx.Quotes.First(p => p.QuoteId == eQuote.QuoteId);



                if (updev.VehicleId != eQuote.VehicleId)
                    updev.VehicleId = eQuote.VehicleId;

                if (updev.ApplicantId != eQuote.ApplicantId)
                    updev.ApplicantId = eQuote.ApplicantId;

                if (updev.AgentId != eQuote.AgentId)
                    updev.AgentId = eQuote.AgentId;

                if (updev.AddressLine1 != eQuote.AddressLine1)
                    updev.AddressLine1 = eQuote.AddressLine1;

                if (updev.AddressLine2 != eQuote.AddressLine2)
                updev.AddressLine2 = eQuote.AddressLine2;


                if (updev.City != eQuote.City)
                    updev.City = eQuote.City;
              
                if (updev.State != eQuote.State)
                    updev.State = eQuote.State;

                if (updev.ZipCode != eQuote.ZipCode)
                    updev.ZipCode = eQuote.ZipCode;
                               
                if (updev.YearsAtAddress != eQuote.YearsAtAddress)
                    updev.YearsAtAddress = eQuote.YearsAtAddress;
               
                if (updev.NumResidentsinHouehold != eQuote.NumResidentsinHouehold)
                    updev.NumResidentsinHouehold = eQuote.NumResidentsinHouehold;

                if (updev.OtherVehiclesInHouseHold != eQuote.OtherVehiclesInHouseHold)
                    updev.OtherVehiclesInHouseHold = eQuote.OtherVehiclesInHouseHold;

                if (updev.MonthsWithCurrentInsurance != eQuote.MonthsWithCurrentInsurance)
                    updev.MonthsWithCurrentInsurance = eQuote.MonthsWithCurrentInsurance;

                if (updev.PriorInsuranceCompany != eQuote.PriorInsuranceCompany)
                    updev.PriorInsuranceCompany = eQuote.PriorInsuranceCompany;

                if (updev.PriorInsuranceCompanyFlag != eQuote.PriorInsuranceCompanyFlag)
                    updev.PriorInsuranceCompanyFlag = eQuote.PriorInsuranceCompanyFlag;

                #region Coverages
                            

                if (updev.LiabilityBIPDCoverage != eQuote.LiabilityBIPDCoverage)
                    updev.LiabilityBIPDCoverage = eQuote.LiabilityBIPDCoverage;

                if (updev.UninsuredMotoristBICoverage != eQuote.UninsuredMotoristBICoverage)
                    updev.UninsuredMotoristBICoverage = eQuote.UninsuredMotoristBICoverage;

                if (updev.UnderinsuredMotoristBICoverage != eQuote.UnderinsuredMotoristBICoverage)
                    updev.UnderinsuredMotoristBICoverage = eQuote.UnderinsuredMotoristBICoverage;

                if (updev.PersonalInjuryProtectionCoverage != eQuote.PersonalInjuryProtectionCoverage)
                    updev.PersonalInjuryProtectionCoverage = eQuote.PersonalInjuryProtectionCoverage;

                if (updev.MedicalPaymentsCoverage != eQuote.MedicalPaymentsCoverage)
                    updev.MedicalPaymentsCoverage = eQuote.MedicalPaymentsCoverage;

                #endregion


                #region Pages Validation

                if (updev.ApplicantQuoteInfoPageValid != eQuote.ApplicantQuoteInfoPageValid)
                    updev.ApplicantQuoteInfoPageValid = eQuote.ApplicantQuoteInfoPageValid;

                if (updev.DriverPageValid != eQuote.DriverPageValid)
                    updev.DriverPageValid = eQuote.DriverPageValid;

                if (updev.VehiclePageValid != eQuote.VehiclePageValid)
                    updev.VehiclePageValid = eQuote.VehiclePageValid;

                if (updev.IncidentPageValid != eQuote.IncidentPageValid)
                    updev.IncidentPageValid = eQuote.IncidentPageValid;

                if (updev.CoveragePageValid != eQuote.CoveragePageValid)
                    updev.CoveragePageValid = eQuote.CoveragePageValid;

                if (updev.RatePageValid != eQuote.RatePageValid)
                    updev.RatePageValid = eQuote.RatePageValid;

                if (updev.QuotePageValid != eQuote.QuotePageValid)
                    updev.QuotePageValid = eQuote.QuotePageValid;

                if (updev.BuyPolicyPageValid != eQuote.BuyPolicyPageValid)
                    updev.BuyPolicyPageValid = eQuote.BuyPolicyPageValid;

                #endregion
                updev.LastModifiedDate = DateTime.Now;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured updating Quote" + ex);
            }
        }

        public void RemoveQuote(int quoteId)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var Quote = context.Quotes.First(p => p.QuoteId == quoteId);
                    context.Quotes.Remove(Quote);
                    context.SaveChanges();

                    //var associatedApplicants = _ctxFunctions..GetAllFollowUpsForQuote(id);

                    //if (associatedFollowUps.Count > 0)
                    //{
                    //    foreach (var fu in associatedFollowUps)
                    //    {
                    //        _ctxFunctions.QuoteFollowUps.Delete(fu.QuoteFollowUpId);
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured deleting a Quote" + ex);
            }
        }
    }
}