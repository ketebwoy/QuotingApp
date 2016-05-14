using System.Web.Mvc;

namespace InsuranceAgencyQuotingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Collect Applicant data sell to insurance agency";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Insurane Agency Contact";

            return View();
        }
    }
}