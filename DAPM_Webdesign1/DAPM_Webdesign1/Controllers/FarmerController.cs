using Microsoft.AspNetCore.Mvc;

namespace DAPM_Webdesign1.Controllers
{
    public class FarmerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Chickens()
        {
            return View();
        }

        public IActionResult Turkeys()
        {
            return View();
        }


    }
}
