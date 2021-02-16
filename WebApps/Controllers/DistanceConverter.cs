namespace WebApps.Controllers
{
    public class DistanceConverterController1 : Controller
    {
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if (converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }

    }
}
}
