 using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL.Managers
{
    public class PoliciesManager
    {
       

 private DataContext _ctx = new DataContext();
    private DataManager _ctxFunctins = DataManager.Instance;


    public Policy GetPolicyById(int policyId)
    {
        try
        {
            return _ctx.Policies.First(p => p.PolicyId == policyId);

        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error occured getting Policy " + policyId + " " + ex);
            //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
            return null;
        }
    }

    public List<Policy> GetAllPolicies()
    {
        try
        {
            return _ctx.Policies.ToList();

        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error occured getting Policies " + ex);
            //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
            return null;
        }
    }

    public int AddPolicy(Policy ePolicy)
    {

        try
        {

            ePolicy.CreatedDate = DateTime.Now;
            ePolicy.LastModifiedDate = DateTime.Now;

            using (var context = new DataContext())
            {
                context.Policies.Add(ePolicy);
                context.SaveChanges();
            }
            return ePolicy.PolicyId;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error occured adding a Policy" + ex);
            //Console.WriteLine("An Error occured adding a Policy" + System.Environment.NewLine + ex);
            return -1;
        }
    }

    public void Update(Policy ePolicy)
    {
        try
        {
            var updev = _ctx.Policies.First(p => p.PolicyId == ePolicy.PolicyId);



            //if (updev. != ePolicy.Make)
            //    updev.Make = ePolicy.Make;

            //if (updev.Model != ePolicy.Model)
            //    updev.Model = ePolicy.Model;

            //if (updev.Year != ePolicy.Year)
            //    updev.Year = ePolicy.Year;

            //if (updev.PhoneNumber != ePolicy.PhoneNumber)
            //    updev.PhoneNumber = ePolicy.PhoneNumber;

            ////if (updev.StartDate != ePolicy.StartDate)
            //    updev.StartDate = ePolicy.StartDate;


            //if (updev.EndDate != ePolicy.EndDate)
            //    updev.EndDate = ePolicy.EndDate;
            //if (updev.EndDate.Year <= 1753)
            //    updev.EndDate = new DateTime().AddYears(1752);


            //if (updev.GroupID != ePolicy.GroupID)
            //    updev.GroupID = ePolicy.GroupID;

            //if (updev.LastDateProcessed != ePolicy.LastDateProcessed)
            //    updev.LastDateProcessed = ePolicy.LastDateProcessed;
            //if (updev.LastDateProcessed.Year <= 1753)
            //    updev.LastDateProcessed = new DateTime().AddYears(1752);


            //if (updev.SendDateTime != ePolicy.SendDateTime)
            //    updev.SendDateTime = ePolicy.SendDateTime;
            //if (updev.SendDateTime.Year <= 1753)
            //    updev.SendDateTime = new DateTime().AddYears(1752);


            //if (updev.EndMarker != ePolicy.EndMarker)
            //    updev.EndMarker = ePolicy.EndMarker;

            //if (updev.HealthTracker != ePolicy.HealthTracker)
            //    updev.HealthTracker = ePolicy.HealthTracker;

            //if (updev.PoliciescaleType != ePolicy.PoliciescaleType)
            //    updev.PoliciescaleType = ePolicy.PoliciescaleType;

            //if (updev.TriggerPoint != ePolicy.TriggerPoint)
            //    updev.TriggerPoint = ePolicy.TriggerPoint;

            //if (updev.DisablePolicyExtension != ePolicy.DisablePolicyExtension)
            //    updev.DisablePolicyExtension = ePolicy.DisablePolicyExtension;

            //if (updev.Frequency != ePolicy.Frequency)
            //    updev.Frequency = ePolicy.Frequency;


            //if (updev.SendDays != ePolicy.SendDays)
            //    updev.SendDays = ePolicy.SendDays;

            //if (updev.VoiceEnabled != ePolicy.VoiceEnabled)
            //    updev.VoiceEnabled = ePolicy.VoiceEnabled;

            updev.LastModifiedDate = DateTime.Now;
            _ctx.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error occured updating Policy" + ex);
        }
    }

    public void RemovePolicy(int PolicyId)
    {
        try
        {
            using (var context = new DataContext())
            {
                var Policy = context.Policies.First(p => p.PolicyId == PolicyId);
                context.Policies.Remove(Policy);
                context.SaveChanges();

                //var associatedApplicants = _ctxFunctions..GetAllFollowUpsForPolicy(id);

                //if (associatedFollowUps.Count > 0)
                //{
                //    foreach (var fu in associatedFollowUps)
                //    {
                //        _ctxFunctions.PolicyFollowUps.Delete(fu.PolicyFollowUpId);
                //    }
                //}
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error occured deleting a Policy" + ex);
        }
    }
}
}