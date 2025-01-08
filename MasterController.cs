using Microsoft.AspNetCore.Mvc;

namespace GFAS.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult LocationMaster()
        {
            return View();
        }
    }
}
