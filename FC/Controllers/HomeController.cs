using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FC.Models;
using FC.CognitiveSevices;
using System.Collections.Generic;

namespace FC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var lst = new List<string>() {

                    "Snakes can help predict future",
                    "The Apple App Store launched in July 2008",
                    "Snakes can help predict earthquakes",
                    "The world’s oldest piece of chewing gum is over 9,000 years old",
                    "Earth has traveled more than 5,000 miles in the past 5 minutes",
                    "Mountain lions can whistle"
                };

                //
                var entities = CongnitiveServices.IdentifyEntities(lst);
                var keyPhrases = CongnitiveServices.IdentifyKeyPhrases(lst);

            }
            catch (System.Exception ex)
            {
                return Json(new { message = ex.Message });
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
