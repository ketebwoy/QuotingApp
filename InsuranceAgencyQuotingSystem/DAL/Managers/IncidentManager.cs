using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Managers
{
    public class IncidentManager
    {
        private DataContext _ctx = new DataContext();
        private DataManager _ctxFunctins = DataManager.Instance;


        public Incident GetIncidentById(int IncidentId)
        {
            try
            {
                return _ctx.Incidents.First(p => p.IncidentId == IncidentId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Incident " + IncidentId + " " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public List<Incident> GetAllIncidents()
        {
            try
            {
                return _ctx.Incidents.ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Incidents " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public int AddIncident(Incident eIncident)
        {

            try
            {

                eIncident.CreatedDate = DateTime.Now;
                eIncident.LastModifiedDate = DateTime.Now;

                using (var context = new DataContext())
                {
                    context.Incidents.Add(eIncident);
                    context.SaveChanges();
                }
                return eIncident.IncidentId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured adding a Incident" + ex);
                //Console.WriteLine("An Error occured adding a Incident" + System.Environment.NewLine + ex);
                return -1;
            }
        }

        public void Update(Incident eIncident)
        {
            try
            {
                var updev = _ctx.Incidents.First(p => p.IncidentId == eIncident.IncidentId);

                if (updev.Type != eIncident.Type)
                    updev.Type = eIncident.Type;

                if (updev.Cost != eIncident.Cost)
                    updev.Cost = eIncident.Cost;

                if (updev.TimeFrame != eIncident.TimeFrame)
                    updev.TimeFrame = eIncident.TimeFrame;

                if (updev.DriverId != eIncident.DriverId)
                    updev.DriverId = eIncident.DriverId;

                if (updev.AtFault != eIncident.AtFault)
                    updev.AtFault = eIncident.AtFault;


               
                updev.LastModifiedDate = DateTime.Now;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured updating Incident" + ex);
            }
        }

        public void RemoveIncident(int IncidentId)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var Incident = context.Incidents.First(p => p.IncidentId == IncidentId);
                    context.Incidents.Remove(Incident);
                    context.SaveChanges();
                                       
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured deleting a Incident" + ex);
            }
        }
    }
}
