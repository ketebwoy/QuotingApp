using DAL.Entities;
using DAL.Managers;
using InsuranceAgencyQuotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace InsuranceAgencyQuotingSystem.Controllers
{
    public class QuoteController : Controller
    {
        #region Properties
        private DataManager _ctx = DataManager.Instance;
        private string _edAPIKey = "ntw94a7mf626pqsdbznxjupd";
        private string _Secret = "hVJ7y9AJuMuGJqpwpMgDuSBB";
        private string _edmoundurl = "https://api.edmunds.com/api/";
        #endregion

        #region Page Actions
        // GET: Quote
        public ActionResult Index()
        {
            return View();
        }

        // GET: Quote/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quote/Create
        public ActionResult CreateCustomer(CreateQuoteModel createQuoteModel)
        {
            if(createQuoteModel.Quote.QuoteId > 1)
            {
                var createQuoteModelNew = createQuoteModel;
                return View(createQuoteModelNew);
            }
            else
            {
                // TODO: Add insert logic here
                var createQuoteModelNew = new CreateQuoteModel();

                // testAgentData 
                createQuoteModelNew.Agent.FirstName = "Keith";
                createQuoteModelNew.Agent.LastName = "Drummond";
                createQuoteModelNew.Agent.EmailAddress = "Agent1@InsuranceAgency.com";
                createQuoteModelNew.Agent.AgentId = 1;
                createQuoteModelNew.Agent.PhoneNumber = "5618460337";
                createQuoteModelNew.Agent.CreatedDate = DateTime.Now.AddDays(-14);
                createQuoteModelNew.Agent.LastModifiedDate = DateTime.Now;
                return View(createQuoteModelNew);
            }

            
        }

        // POST: Quote/Create
        [HttpPost]
        public ActionResult CreateCustomer(Applicant applicant)
        {
            try
            {
                var createQuoteModel = new CreateQuoteModel();

                createQuoteModel.Applicant = applicant; 

                createQuoteModel.Applicant.ApplicantId = _ctx.Applicants.AddApplicant(applicant);
                createQuoteModel.Quote.ApplicantPageValid = true;
                createQuoteModel.Quote.ApplicantId = createQuoteModel.Applicant.ApplicantId;
                createQuoteModel.Quote.ApplicantPageValid = true;
                createQuoteModel.Quote.QuoteId = _ctx.Quotes.AddQuote(createQuoteModel.Quote);



                TempData["createQuoteModel"] = createQuoteModel;
                return RedirectToAction("CreatePolicy", createQuoteModel);
            }
            catch
            {
                return View(); 
                
            }
        }

        public ActionResult CreatePolicy(CreateQuoteModel createQuoteModel2)
        {
            var createQuoteModel = (CreateQuoteModel)TempData["createQuoteModel"];

            if(createQuoteModel == null)
            {
                createQuoteModel = new CreateQuoteModel(); 
            }
            return View(createQuoteModel);
        }

        [HttpPost]
        public ActionResult CreatePolicy(Quote quote)
        {
            try
                {
                var createQuoteModel = new CreateQuoteModel();
                createQuoteModel.Applicant = _ctx.Applicants.GetApplicantById(quote.ApplicantId);
                quote.AgentId = -1;
                quote.ApplicantPageValid = true;
                quote.ApplicantQuoteInfoPageValid = true;

                createQuoteModel.Quote = quote;
                _ctx.Quotes.Update(quote);

                TempData["createQuoteModel"] = createQuoteModel;
                return RedirectToAction("CreateVehicles", createQuoteModel);
                }
                catch (Exception ex)
                {
                    return View();
                    throw;
                }
            
        }

        public ActionResult CreateDrivers()
        {
            var createQuoteModel = new CreateQuoteModel(); // (CreateQuoteModel)TempData["createQuoteModel"];
            createQuoteModel.Drivers = _ctx.Drivers.GetAllDrivers(); 
            return View(createQuoteModel); 
        }

        [HttpPost]
        public ActionResult CreateDrivers(string submitform, Driver driver)
        {
            if(ModelState.IsValid)
            {
                _ctx.Drivers.AddDriver(driver);
            }

            var createQuoteModel = new CreateQuoteModel(); 
            if (submitform == "Add")
            {
                //go back to vehicle page      
                createQuoteModel.Drivers.Add(driver);          
                return RedirectToAction("CreateDrivers", createQuoteModel);
            }
            else
            {
                createQuoteModel.Drivers.Add(driver);
                return RedirectToAction("CreateCoverage", createQuoteModel);
            }
         }

        public ActionResult VehicleDriverLink()
        {
            var createQuoteModel = new CreateQuoteModel();
            createQuoteModel.Drivers = _ctx.Drivers.GetAllDrivers();

            createQuoteModel.Vehicles = _ctx.Vehicles.GetAllVehicles(); 
             
            return View(createQuoteModel);
        }

        [HttpPost]
        public ActionResult VehicleDriverLink(FormCollection collection)
        {
            var createQuoteModel = new CreateQuoteModel(); 
            foreach(var key in collection)
            {
                var test = key;

                if(key.ToString().Contains("driver"))
                {
                    var Id = collection[key.ToString()].Split('_')[0];
                    var driverId = Convert.ToInt32(Id);
                    var vehicleId = Convert.ToInt32(key.ToString().Split('_')[1]);

                    if (vehicleId > 0 && driverId > 0)
                    {
                        var vehicle = _ctx.Vehicles.GetVehicleById(vehicleId);
                        vehicle.DriverId = driverId;
                        _ctx.Vehicles.Update(vehicle);
                    }

                }
                
            }
            return RedirectToAction("AddIncidents", createQuoteModel);
        }

        public ActionResult AddIncidents(CreateQuoteModel cqm)
        {

            var createQuoteModel = new CreateQuoteModel();
            createQuoteModel.Drivers = _ctx.Drivers.GetAllDrivers();

            createQuoteModel.Vehicles = _ctx.Vehicles.GetAllVehicles();

            var incidents = _ctx.Incidents.GetAllIncidents(); 
            return View(createQuoteModel);
        }

        [HttpPost]
        public ActionResult AddIncidents(string submitform, Incident incident)
        {
            var createQuoteModel = new CreateQuoteModel();

            if (ModelState.IsValid)
            {
                _ctx.Incidents.AddIncident(incident);

            }

            if (submitform == "Add")
            {
                //go back to vehicle page      
                createQuoteModel.Incidents.Add(incident);
                return View("AddIncidents", createQuoteModel);
            }
            else
            {
                createQuoteModel.Incidents.Add(incident);
                return View("CreateCoverage", createQuoteModel);
            }

            
        }

        public ActionResult CreateVehicles()
        {
            var createQuoteModel = new CreateQuoteModel();  //(CreateQuoteModel)TempData["createQuoteModel"];
            createQuoteModel.Applicant = _ctx.Applicants.GetApplicantById(55);
            createQuoteModel.Quote = _ctx.Quotes.GetQuoteById(16);
            createQuoteModel.Vehicles = _ctx.Vehicles.GetAllVehicles().FindAll(p => p.QuoteId == 16); 
            return View(createQuoteModel);
        }

        [HttpPost]
        public ActionResult CreateVehicles(string submitform, FormCollection collection)
        {
            var createQuoteModel = new CreateQuoteModel();
            
            #region buildVehicle
            var applicantId = Convert.ToInt32(collection["Quote.ApplicantId"]);
            var quoteId = Convert.ToInt32(collection["Quote.QuoteId"]);
            var applicant = _ctx.Applicants.GetApplicantById(applicantId);
            var quote = _ctx.Quotes.GetQuoteById(10);
            var newVehicle = new Vehicle(); 
            createQuoteModel.Applicant = applicant;

            newVehicle.Year = collection["Vehicle.Year"];
            newVehicle.Make = collection["Vehicle.Make"];
            newVehicle.Model = collection["Vehicle.Model"];
            newVehicle.Detail = collection["Vehicle.Detail"];
            newVehicle.CostNew = Convert.ToDouble(collection["Vehicle.CostNew"]);
            newVehicle.DriveTrainWheels = collection["Vehicle.DriveTrainWheels"];
            newVehicle.YearsOwnedLeased = Convert.ToInt32(collection["Vehicle.YearsOwnedLeased"]);
            newVehicle.GaragedElseWhere = Convert.ToBoolean(collection["Vehicle.GaragedElseWhere"]);

            

           // if (newVehicle.GaragedElseWhere)
            //{
                //get garaging address
                //newVehicle.GaragingAddress1 = collection["Vehicle.GaragedElseWhere"];
                //newVehicle.GaragingAddress2 = collection["Vehicle.GaragedElseWhere"];
                //newVehicle.GaragingCity = collection["Vehicle.GaragedElseWhere"];
                //newVehicle.GaragingState = collection["Vehicle.GaragedElseWhere"];
                //newVehicle.GaragingZipCode = collection["Vehicle.GaragedElseWhere"];
            //}
            //else
            //{
                newVehicle.GaragingAddress1 = quote.AddressLine1;
                newVehicle.GaragingAddress2 = quote.AddressLine2;
                newVehicle.GaragingCity = quote.City;
                newVehicle.GaragingState = quote.State;
                newVehicle.GaragingZipCode = quote.ZipCode;
            //}

            newVehicle.MilesToWorkSchool = collection["Vehicle.MilesToWorkSchool"];
            newVehicle.AnnualMileage = collection["Vehicle.AnnualMileage"];
            newVehicle.FarmUse = Convert.ToBoolean(collection["Vehicle.FarmUse"]);

            Titled titled;
            Enum.TryParse(collection["Vehicle.Titled"], out titled);

            VehicleUsuage usage;
            Enum.TryParse(collection["Vehicle.usage"], out usage);

            newVehicle.Titled = titled;
            newVehicle.Usage = usage;
            newVehicle.QuoteId = quoteId;

            _ctx.Vehicles.AddVehicle(newVehicle);

            var quoteVehicles = _ctx.Vehicles.GetAllVehicles();
            createQuoteModel.Vehicles.Add(newVehicle);
            #endregion  

            if (submitform == "Add")
            {
                //go back to vehicle page                
                return RedirectToAction("CreateVehicles", createQuoteModel);
            }
            else
            {
                createQuoteModel.Quote = _ctx.Quotes.GetQuoteById(quoteId); 
                createQuoteModel.Quote.VehiclePageValid = true;
                _ctx.Quotes.Update(createQuoteModel.Quote);
                return RedirectToAction("CreateDrivers", createQuoteModel);
            }
        }

        public ActionResult CreateCoverage(CreateQuoteModel createQuoteModel2)
        {
            var createQuoteModel = new CreateQuoteModel();
            createQuoteModel.Drivers = _ctx.Drivers.GetAllDrivers();

            createQuoteModel.Vehicles = _ctx.Vehicles.GetAllVehicles();

            var incidents = _ctx.Incidents.GetAllIncidents();
            return View(createQuoteModel);
            
        }

        [HttpPost]
        public ActionResult CreateCoverage(FormCollection collection)
        {
            var createQuoteModel = new CreateQuoteModel(); 

            var quoteId = Convert.ToInt32(collection["Quote.QuoteId"]);
            var liability = Convert.ToInt32(collection["Coverages.LiabilityLimits"]);
            var uninsuredMotorist = Convert.ToInt32(collection["Coverages.UninsuredMotoristBILimits"]);
            var medicalPayments = Convert.ToInt32(collection["Coverages.MedicalPaymentsLimits"]);
            var pip = Convert.ToInt32(collection["Coverages.PersonalInjuryProtectionLimits"]);
            var driverId = Convert.ToInt32(collection["DriverId"]);


            var quote = _ctx.Quotes.GetQuoteById(quoteId);
            quote.LiabilityBIPDCoverage = liability;
            quote.UninsuredMotoristBICoverage = uninsuredMotorist;
            quote.MedicalPaymentsCoverage = medicalPayments;
            quote.PersonalInjuryProtectionCoverage = pip;

            _ctx.Quotes.Update(quote);


            return RedirectToAction("Rate", createQuoteModel);
        }
        
     

        public ActionResult Rate(CreateQuoteModel createQuoteModel)
        {
            return View(createQuoteModel);
        }

        [HttpPost]
        public ActionResult Rate(FormCollection collection)
        {
            return View();
        }


        public ActionResult BuyPolicy(CreateQuoteModel createQuoteModel)
        {
            return View(createQuoteModel);
        }

        [HttpPost]
        public ActionResult BuyPolicy(FormCollection collection)
        {
            return View();
        }
        // GET: Quote/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quote/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quote/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quote/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Json Actions 

        [HttpPost]
        public JsonResult UpdateVehicleCoverage(string vId, string comp, string rental, string roadside, string gap)
        {
            try
            {

                //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                //    var test = Convert.ToString(Request.QueryString["vehicleId"]);

                var vehId = Convert.ToInt32(vId);
                var vehicle = _ctx.Vehicles.GetVehicleById(vehId);
                vehicle.ComprehensiveCoverage = Convert.ToInt32(comp);
                vehicle.RentalCoverage = Convert.ToInt32(rental);
                vehicle.RoadSideCoverage = Convert.ToBoolean(roadside);
                vehicle.GapCoverage = Convert.ToBoolean(gap);


                /// _ctx.Vehicles.Update(vehicle);
                return Json(true, JsonRequestBehavior.AllowGet); ;
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet); ;
            }

        }

        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult QuotesJSON()
        {
            var quotes = _ctx.Quotes.GetAllQuotes(); 
            return Json(quotes, JsonRequestBehavior.AllowGet);
        }


        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult GetVehicleMakesJSON(string id)
        {
            var urlSuffix = string.Format("/vehicle/v2/makes?state=used&year={0}&view=basic&fmt=json&api_key={1}", id, _edAPIKey);
            var req = _edmoundurl + urlSuffix;


            var quotes = _ctx.Quotes.GetAllQuotes();
            return Json(quotes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddVehicle(FormCollection collection)
        {
            return Json("test", JsonRequestBehavior.AllowGet);
        }


        #endregion



    }


}
