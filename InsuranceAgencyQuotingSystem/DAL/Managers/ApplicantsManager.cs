using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Managers
{
    public class ApplicantsManager
    {
        private DataContext _ctx = new DataContext();
        private DataManager _ctxFunctins = DataManager.Instance;


        public Applicant GetApplicantById(int ApplicantId)
        {
            try
            {
                return _ctx.Applicants.First(p => p.ApplicantId == ApplicantId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Applicant " + ApplicantId + " " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public List<Applicant> GetAllApplicants()
        {
            try
            {
                return _ctx.Applicants.ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Applicants " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public int AddApplicant(Applicant eApplicant)
        {

            try
            {

                eApplicant.CreatedDate = DateTime.Now;
                eApplicant.LastModifiedDate = DateTime.Now;

                using (var context = new DataContext())
                {
                    context.Applicants.Add(eApplicant);
                    context.SaveChanges();
                }
                return eApplicant.ApplicantId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured adding a Applicant" + ex);
                //Console.WriteLine("An Error occured adding a Applicant" + System.Environment.NewLine + ex);
                return -1;
            }
        }

        public void Update(Applicant eApplicant)
        {
            try
            {
                var updev = _ctx.Applicants.First(p => p.ApplicantId == eApplicant.ApplicantId);



                if (updev.FirstName != eApplicant.FirstName)
                    updev.FirstName = eApplicant.FirstName;

                if (updev.LastName != eApplicant.LastName)
                    updev.LastName = eApplicant.LastName;

                if (updev.EmailAddress != eApplicant.EmailAddress)
                    updev.EmailAddress = eApplicant.EmailAddress;

                if (updev.PhoneNumber != eApplicant.PhoneNumber)
                    updev.PhoneNumber = eApplicant.PhoneNumber;

                //if (updev.StartDate != eApplicant.StartDate)
                //    updev.StartDate = eApplicant.StartDate;


                //if (updev.EndDate != eApplicant.EndDate)
                //    updev.EndDate = eApplicant.EndDate;
                //if (updev.EndDate.Year <= 1753)
                //    updev.EndDate = new DateTime().AddYears(1752);


                //if (updev.GroupID != eApplicant.GroupID)
                //    updev.GroupID = eApplicant.GroupID;

                //if (updev.LastDateProcessed != eApplicant.LastDateProcessed)
                //    updev.LastDateProcessed = eApplicant.LastDateProcessed;
                //if (updev.LastDateProcessed.Year <= 1753)
                //    updev.LastDateProcessed = new DateTime().AddYears(1752);


                //if (updev.SendDateTime != eApplicant.SendDateTime)
                //    updev.SendDateTime = eApplicant.SendDateTime;
                //if (updev.SendDateTime.Year <= 1753)
                //    updev.SendDateTime = new DateTime().AddYears(1752);


                //if (updev.EndMarker != eApplicant.EndMarker)
                //    updev.EndMarker = eApplicant.EndMarker;

                //if (updev.HealthTracker != eApplicant.HealthTracker)
                //    updev.HealthTracker = eApplicant.HealthTracker;

                //if (updev.ApplicantScaleType != eApplicant.ApplicantScaleType)
                //    updev.ApplicantScaleType = eApplicant.ApplicantScaleType;

                //if (updev.TriggerPoint != eApplicant.TriggerPoint)
                //    updev.TriggerPoint = eApplicant.TriggerPoint;

                //if (updev.DisableApplicantExtension != eApplicant.DisableApplicantExtension)
                //    updev.DisableApplicantExtension = eApplicant.DisableApplicantExtension;

                //if (updev.Frequency != eApplicant.Frequency)
                //    updev.Frequency = eApplicant.Frequency;


                //if (updev.SendDays != eApplicant.SendDays)
                //    updev.SendDays = eApplicant.SendDays;

                //if (updev.VoiceEnabled != eApplicant.VoiceEnabled)
                //    updev.VoiceEnabled = eApplicant.VoiceEnabled;

                updev.LastModifiedDate = DateTime.Now;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured updating Applicant" + ex);
            }
        }

        public void RemoveApplicant(int id)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var Applicant = context.Applicants.First(p => p.ApplicantId == id);
                    context.Applicants.Remove(Applicant);
                    context.SaveChanges();

                    //var associatedApplicants = _ctxFunctions..GetAllFollowUpsForApplicant(id);

                    //if (associatedFollowUps.Count > 0)
                    //{
                    //    foreach (var fu in associatedFollowUps)
                    //    {
                    //        _ctxFunctions.ApplicantFollowUps.Delete(fu.ApplicantFollowUpId);
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured deleting a Applicant" + ex);
            }
        }
    }
}