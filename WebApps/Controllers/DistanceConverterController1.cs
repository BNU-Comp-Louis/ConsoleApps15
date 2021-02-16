namespace WebApps.Controllers
{

    using ConsoleAppProject.App01;
    using Microsoft.AspNetCore.Mvc;



    public class DistanceConverterController1 : Controller
    {
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if (Converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }

    }
}