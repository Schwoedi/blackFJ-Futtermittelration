using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DAPM_Webdesign1.Controllers
{
    public class FutterController : Controller
    {
        public IActionResult Index()
        {
            List<string> options = new List<string>
            {
                "Option1",
                "Option2",
                "Option3",
                "Option4",
                "Option5",
                "Option6"
            };
            ViewBag.Options = new SelectList(options);

            return View();
        }
        public IActionResult Futtermittel(string selectedOption)
        {
            ViewBag.SelectedOption = selectedOption;
            return View();
        }
        [HttpPost]
        public ActionResult ProcessFuttermittel(FormCollection form)
        {
            // Verarbeite die eingegebenen Futtermittel hier
            // form["futtermittel_1"], form["futtermittel_2"], usw.

            return RedirectToAction("Index");
        }
    }
}
