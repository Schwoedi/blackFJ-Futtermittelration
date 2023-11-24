using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static DAPM_Webdesign2.Models.Rationen;

namespace DAPM_Webdesign2.Controllers
{
    public class RationController:Controller
    {

        private readonly MyDbContext _context;

        public RationController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Rations.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RationController model)
        {
            if (ModelState.IsValid)
            {
                var ration = new Ration
                {
                    Name = model.Name,
                    Type = model.Type,
                    Description = model.Description
                };

                _context.Rations.Add(ration);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Die Ration wurde erfolgreich erstellt.";

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = new RationDetailsViewModel
            {
                Ration = _context.Rations.Find(id)
            };

            return View(model);
        }
    }
}
