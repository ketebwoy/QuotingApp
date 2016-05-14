using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Managers
{
    public class VehiclesManager
    {
        private DataContext _ctx = new DataContext();
        private DataManager _ctxFunctins = DataManager.Instance;


        public Vehicle GetVehicleById(int vehicleId)
        {
            try
            {
                return _ctx.Vehicles.First(p => p.VehicleId == vehicleId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Vehicle " + vehicleId + " " + ex);
                return null;
            }
        }

        public List<Vehicle> GetAllVehicles()
        {
            try
            {
                return _ctx.Vehicles.ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured getting Vehicles " + ex);
                return null;
            }
        }

        public int AddVehicle(Vehicle eVehicle)
        {

            try
            {

                eVehicle.CreatedDate = DateTime.Now;
                eVehicle.LastModifiedDate = DateTime.Now;

                using (var context = new DataContext())
                {
                    context.Vehicles.Add(eVehicle);
                    context.SaveChanges();
                }
                return eVehicle.VehicleId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured adding a Vehicle" + ex);
                  return -1;
            }
        }

        public void Update(Vehicle eVehicle)
        {
            try
            {
                var updev = _ctx.Vehicles.First(p => p.VehicleId == eVehicle.VehicleId);



                if (updev.Make != eVehicle.Make)
                    updev.Make = eVehicle.Make;

                if (updev.Model != eVehicle.Model)
                    updev.Model = eVehicle.Model;

                if (updev.Year != eVehicle.Year)
                    updev.Year = eVehicle.Year;

                if (updev.Detail != eVehicle.Detail)
                    updev.Detail = eVehicle.Detail;

                if (updev.CostNew != eVehicle.CostNew)
                    updev.CostNew = eVehicle.CostNew;

                if (updev.DriveTrainWheels != eVehicle.DriveTrainWheels)
                    updev.DriveTrainWheels = eVehicle.DriveTrainWheels;

                if (updev.Titled != eVehicle.Titled)
                    updev.Titled = eVehicle.Titled;

                if (updev.OwnedLeased != eVehicle.OwnedLeased)
                    updev.OwnedLeased = eVehicle.OwnedLeased;

                if (updev.YearsOwnedLeased != eVehicle.YearsOwnedLeased)
                    updev.YearsOwnedLeased = eVehicle.YearsOwnedLeased;

                if (updev.GaragedElseWhere != eVehicle.GaragedElseWhere)
                    updev.GaragedElseWhere = eVehicle.GaragedElseWhere;


                if (updev.GaragingAddress1 != eVehicle.GaragingAddress1)
                    updev.GaragingAddress1 = eVehicle.GaragingAddress1;

                if (updev.GaragingAddress2 != eVehicle.GaragingAddress2)
                    updev.GaragingAddress2 = eVehicle.GaragingAddress2;

                if (updev.GaragingCity != eVehicle.GaragingCity)
                    updev.GaragingCity = eVehicle.GaragingCity;

                if (updev.GaragingZipCode != eVehicle.GaragingZipCode)
                    updev.GaragingZipCode = eVehicle.GaragingZipCode;

                if (updev.GaragingState != eVehicle.GaragingState)
                    updev.GaragingState= eVehicle.GaragingState;

                if (updev.MilesToWorkSchool != eVehicle.MilesToWorkSchool)
                    updev.MilesToWorkSchool = eVehicle.MilesToWorkSchool;

                if (updev.AnnualMileage != eVehicle.AnnualMileage)
                    updev.AnnualMileage = eVehicle.AnnualMileage;

                if (updev.Usage != eVehicle.Usage)
                    updev.Usage = eVehicle.Usage;

                if (updev.FarmUse != eVehicle.FarmUse)
                    updev.FarmUse = eVehicle.FarmUse;

                if (updev.ComprehensiveCoverage != eVehicle.ComprehensiveCoverage)
                    updev.ComprehensiveCoverage = eVehicle.ComprehensiveCoverage;

                if (updev.CollisionCoverage != eVehicle.CollisionCoverage)
                    updev.CollisionCoverage = eVehicle.CollisionCoverage;

                if (updev.RentalCoverage != eVehicle.RentalCoverage)
                    updev.RentalCoverage = eVehicle.RentalCoverage;

                if (updev.RoadSideCoverage != eVehicle.RoadSideCoverage)
                    updev.RoadSideCoverage = eVehicle.RoadSideCoverage;


                if (updev.GapCoverage != eVehicle.GapCoverage)
                    updev.GapCoverage = eVehicle.GapCoverage;

                updev.LastModifiedDate = DateTime.Now;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured updating Vehicle" + ex);
            }
        }

        public void RemoveVehicle(int vehicleId)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var Vehicle = context.Vehicles.First(p => p.VehicleId == vehicleId);
                    context.Vehicles.Remove(Vehicle);
                    context.SaveChanges();
                                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured deleting a Vehicle" + ex);
            }
        }
    }
}