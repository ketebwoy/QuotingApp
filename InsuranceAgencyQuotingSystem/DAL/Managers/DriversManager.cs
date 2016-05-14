using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Managers
{
    public class DriversManager
    {
        private DataContext _ctx = new DataContext();
        private DataManager _ctxFunctins = DataManager.Instance;


        public Driver GetDriverById(int DriverId)
        {
            try
            {
                return _ctx. Drivers.First(p => p.DriverId == DriverId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Driver " + DriverId + " " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public List<Driver> GetAllDrivers()
        {
            try
            {
                return _ctx.Drivers.ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Drivers " + ex);
                //Console.WriteLine("An Error occured getting campaignTemplate" + System.Environment.NewLine + ex);
                return null;
            }
        }

        public int AddDriver(Driver eDriver)
        {

            try
            {

                eDriver.CreatedDate = DateTime.Now;
                eDriver.LastModifiedDate = DateTime.Now;

                using (var context = new DataContext())
                {
                    context.Drivers.Add(eDriver);
                    context.SaveChanges();
                }
                return eDriver.DriverId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured adding a Driver" + ex);
                //Console.WriteLine("An Error occured adding a Driver" + System.Environment.NewLine + ex);
                return -1;
            }
        }

        public void Update(Driver eDriver)
        {
            try
            {
                var updev = _ctx.Drivers.First(p => p.DriverId == eDriver.DriverId);

                if (updev.CoApplicantFlag != eDriver.CoApplicantFlag)
                    updev.CoApplicantFlag = eDriver.CoApplicantFlag;

                if (updev.FirstName != eDriver.FirstName)
                    updev.FirstName = eDriver.FirstName;

                if (updev.LastName != eDriver.LastName)
                    updev.LastName = eDriver.LastName;

                if (updev.MiddleInit != eDriver.MiddleInit)
                    updev.MiddleInit = eDriver.MiddleInit;

                if (updev.DateOfBirth != eDriver.DateOfBirth)
                    updev.DateOfBirth = eDriver.DateOfBirth;


                if (updev.Gender != eDriver.Gender)
                    updev.Gender = eDriver.Gender;
                

                if (updev.AgeFirstLicensed != eDriver.AgeFirstLicensed)
                    updev.AgeFirstLicensed = eDriver.AgeFirstLicensed;

                if (updev.DriversLicenseNumber != eDriver.DriversLicenseNumber)
                    updev.DriversLicenseNumber = eDriver.DriversLicenseNumber;


                if (updev.State != eDriver.State)
                    updev.State = eDriver.State;
               

                if (updev.Occupation != eDriver.Occupation)
                    updev.Occupation = eDriver.Occupation;

                if (updev.EducationLevel != eDriver.EducationLevel)
                    updev.EducationLevel = eDriver.EducationLevel;

                if (updev.CriminalRecord != eDriver.CriminalRecord)
                    updev.CriminalRecord = eDriver.CriminalRecord;

                if (updev.CancelledNonRenew != eDriver.CancelledNonRenew)
                    updev.CancelledNonRenew = eDriver.CancelledNonRenew;

                //if (updev.DisableDriverExtension != eDriver.DisableDriverExtension)
                //    updev.DisableDriverExtension = eDriver.DisableDriverExtension;

                //if (updev.Frequency != eDriver.Frequency)
                //    updev.Frequency = eDriver.Frequency;


                //if (updev.SendDays != eDriver.SendDays)
                //    updev.SendDays = eDriver.SendDays;

                //if (updev.VoiceEnabled != eDriver.VoiceEnabled)
                //    updev.VoiceEnabled = eDriver.VoiceEnabled;

                updev.LastModifiedDate = DateTime.Now;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured updating Driver" + ex);
            }
        }

        public void RemoveDriver(int DriverId)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var Driver = context.Drivers.First(p => p.DriverId == DriverId);
                    context.Drivers.Remove(Driver);
                    context.SaveChanges();

                    //var associatedApplicants = _ctxFunctions..GetAllFollowUpsForDriver(id);

                    //if (associatedFollowUps.Count > 0)
                    //{
                    //    foreach (var fu in associatedFollowUps)
                    //    {
                    //        _ctxFunctions.DriverFollowUps.Delete(fu.DriverFollowUpId);
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured deleting a Driver" + ex);
            }
        }
    }
}
