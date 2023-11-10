using Microsoft.AspNetCore.Mvc;

namespace DAPM_Webdesign2.Controllers
{
    public class MeineRationenController : Controller
    {
        public IActionResult Rationen()
        {
            return View();
        }

        public IActionResult Auswahl1()
        {
            return View();
        }

        public IActionResult Auswahl2()
        {
            return View();
        }

        // ... weitere Auswahlmöglichkeiten ...
    }
}
