using Microsoft.AspNetCore.Mvc;

namespace GFAS.Controllers
{
    public class GeoController : Controller
    {
        public IActionResult GeoFencing()
        {
            return View();
        }
    }
}
