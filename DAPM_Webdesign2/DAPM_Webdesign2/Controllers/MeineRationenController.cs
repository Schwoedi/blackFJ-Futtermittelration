using Microsoft.AspNetCore.Mvc;

namespace DAPM_Webdesign2.Controllers
{
    public class MeineRationenController : Controller
    {
        public IActionResult Rationen()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GefluegelAuswahl(string gefluegel)
        {
            if (gefluegel == "Huhn")
            {
                return RedirectToAction("HuhnAuswahl");
            }
            else if (gefluegel == "Pute")
            {
                return RedirectToAction("PuteAuswahl");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult HuhnAuswahl()
        {
            // Logik für die Huhn-Auswahlseite
            return View();
        }

        public ActionResult PuteAuswahl()
        {
            // Logik für die Pute-Auswahlseite
            return View();
        }

        // Weitere Aktionen für HuhnOption1, HuhnOption2, PuteOption1, PuteOption2

        [HttpPost]
        public ActionResult FutterHinzufuegen(string gefluegelArt)
        {
            // Logik zum Hinzufügen der Futterration
            return RedirectToAction("Rationen");
        }
    }
}
