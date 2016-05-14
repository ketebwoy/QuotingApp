using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Managers
{
    public class AgentsManager
    {
        private DataContext _ctx = new DataContext();
        private DataManager _ctxFunctins = DataManager.Instance;


        public Agent GetAgentById(int agentId)
        {
            try
            {
                return _ctx.Agents.First(p => p.AgentId == agentId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting agent "+ agentId +" " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public List<Agent> GetAllAgents()
        {
            try
            {
                return _ctx.Agents.ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting agents " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public int AddAgent(Agent eAgent)
        {
            
            try
            {

                eAgent.CreatedDate = DateTime.Now;
                eAgent.LastModifiedDate = DateTime.Now;

                using (var context = new DataContext())
                {
                    context.Agents.Add(eAgent);
                    context.SaveChanges();
                }
                return eAgent.AgentId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured adding a Agent" + ex);
                //Console.WriteLine("An Error occured adding a Agent" + System.Environment.NewLine + ex);
                return -1;
            }
        }

        public void Update(Agent eAgent)
        {
            try
            {
                var updev = _ctx.Agents.First(p => p.AgentId == eAgent.AgentId);

                

                if (updev.FirstName != eAgent.FirstName)
                    updev.FirstName = eAgent.FirstName;

                if (updev.LastName != eAgent.LastName)
                    updev.LastName = eAgent.LastName;

                if (updev.EmailAddress != eAgent.EmailAddress)
                    updev.EmailAddress = eAgent.EmailAddress;

                if (updev.PhoneNumber != eAgent.PhoneNumber)
                    updev.PhoneNumber = eAgent.PhoneNumber;

                //if (updev.StartDate != eAgent.StartDate)
                //    updev.StartDate = eAgent.StartDate;


                //if (updev.EndDate != eAgent.EndDate)
                //    updev.EndDate = eAgent.EndDate;
                //if (updev.EndDate.Year <= 1753)
                //    updev.EndDate = new DateTime().AddYears(1752);


                //if (updev.GroupID != eAgent.GroupID)
                //    updev.GroupID = eAgent.GroupID;

                //if (updev.LastDateProcessed != eAgent.LastDateProcessed)
                //    updev.LastDateProcessed = eAgent.LastDateProcessed;
                //if (updev.LastDateProcessed.Year <= 1753)
                //    updev.LastDateProcessed = new DateTime().AddYears(1752);


                //if (updev.SendDateTime != eAgent.SendDateTime)
                //    updev.SendDateTime = eAgent.SendDateTime;
                //if (updev.SendDateTime.Year <= 1753)
                //    updev.SendDateTime = new DateTime().AddYears(1752);


                //if (updev.EndMarker != eAgent.EndMarker)
                //    updev.EndMarker = eAgent.EndMarker;

                //if (updev.HealthTracker != eAgent.HealthTracker)
                //    updev.HealthTracker = eAgent.HealthTracker;

                //if (updev.AgentScaleType != eAgent.AgentScaleType)
                //    updev.AgentScaleType = eAgent.AgentScaleType;

                //if (updev.TriggerPoint != eAgent.TriggerPoint)
                //    updev.TriggerPoint = eAgent.TriggerPoint;

                //if (updev.DisableAgentExtension != eAgent.DisableAgentExtension)
                //    updev.DisableAgentExtension = eAgent.DisableAgentExtension;

                //if (updev.Frequency != eAgent.Frequency)
                //    updev.Frequency = eAgent.Frequency;


                //if (updev.SendDays != eAgent.SendDays)
                //    updev.SendDays = eAgent.SendDays;

                //if (updev.VoiceEnabled != eAgent.VoiceEnabled)
                //    updev.VoiceEnabled = eAgent.VoiceEnabled;

                updev.LastModifiedDate = DateTime.Now; 
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured updating Agent" + ex);
            }
        }

        public void RemoveAgent(int id)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var Agent = context.Agents.First(p => p.AgentId == id);
                    context.Agents.Remove(Agent);
                    context.SaveChanges();

                    //var associatedApplicants = _ctxFunctions..GetAllFollowUpsForAgent(id);

                    //if (associatedFollowUps.Count > 0)
                    //{
                    //    foreach (var fu in associatedFollowUps)
                    //    {
                    //        _ctxFunctions.AgentFollowUps.Delete(fu.AgentFollowUpId);
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured deleting a Agent" + ex);
            }
        }


    }
}