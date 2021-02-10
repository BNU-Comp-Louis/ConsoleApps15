using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App01;
using Microsoft.AspNetCore.Mvc;

namespace WebApps.Controllers
{

    public class DistanceConverterController1 : Controller
     {
        public IActionResult Converter()
        {
            return View();
        }
     }

}
