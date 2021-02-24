using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using WebApps.Models;



namespace WebApps.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if (converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }

        [HttpGet]
        public IActionResult BmiCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BmiCalculator(BmiCalculator bmi)
        {
            if(bmi.Centimetres > 140)
            {
                bmi.CalculateMetric();
            }
            else if (bmi.Feet > 4 && bmi.Stone > 6)
            {
                bmi.CalculateImperial();
            }
            else
            {
                ViewBag.Error = "You have entered values too small for any adult!";
                return View();
            }
            double BmiUser = bmi.BmiUser;
            return RedirectToAction("HealthMessage" , new { BmiUser } );
        }

        public IActionResult HealthMessage(double BmiUser)
        {
            return View(BmiUser);
        }
        public IActionResult StudentMarks()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}