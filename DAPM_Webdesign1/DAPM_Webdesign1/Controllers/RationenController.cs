using DAPM_Webdesign1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DAPM_Webdesign1.Controllers
{
    public class RationenController : Controller
    {
        public IActionResult RationsrechnerP()
        {
            ViewBag.PhaseOptions = GetPhaseOptions();
            ViewBag.FuttermittelOptions = GetFuttermittelOptions();
            return View();
        }
        public IActionResult RationsrechnerH()
        {
            ViewBag.PhaseOptions = GetPhaseOptions();
            ViewBag.FuttermittelOptions = GetFuttermittelOptions();
            return View();
        }

        [HttpPost]
        public ActionResult CalculateRation(RationsrechnerViewModel viewModel)
        {
            // Hier können Sie die Berechnungen für die Ration durchführen
            // Je nach Anforderung sollten Sie hier Ihre Geschäftslogik implementieren

            // Beispiel: Einfache Berechnung
            int totalFutterMenge = viewModel.AnzahlTiere * viewModel.FuttermittelMenge;

            ViewBag.TotalFutterMenge = totalFutterMenge;
            return View("RationsResult", viewModel);
        }

        private IEnumerable<SelectListItem> GetPhaseOptions()
        {
            return new[]
            {
            new SelectListItem { Value = "1", Text = "Phase 1" },
            new SelectListItem { Value = "2", Text = "Phase 2" },
            new SelectListItem { Value = "3", Text = "Phase 3" },
            new SelectListItem { Value = "4", Text = "Phase 4" }
        };
        }

        private IEnumerable<SelectListItem> GetFuttermittelOptions()
        {
            return new[]
            {
            new SelectListItem { Value = "Weizen", Text = "Weizen" },
            new SelectListItem { Value = "Gerste", Text = "Gerste" },
            new SelectListItem { Value = "Mais", Text = "Mais" },
            new SelectListItem { Value = "Bohnen", Text = "Bohnen" },
            new SelectListItem { Value = "Hirse", Text = "Hirse" },

            // Weitere Futtermittel hier hinzufügen...
        };
        }

 

        public IActionResult Result()
        {
            return View();
        }

    }
}
