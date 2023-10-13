using DAPM_Webdesign1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DAPM_Webdesign1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BerechneRation(string Futtermittel1, string Menge, string Einheit)
        {
            // Hier können Sie die Logik zur Berechnung der Ration basierend auf den Dropdown-Werten implementieren.
            // Beispiel: Ration = Futtermittel * Menge * Einheit

            // Nehmen wir an, wir wollen die Ration einfach in der View anzeigen.
            string ration = $"Ration: {Menge} {Einheit} {Futtermittel1}";

            return View("RationsErgebnis", (object)ration);
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