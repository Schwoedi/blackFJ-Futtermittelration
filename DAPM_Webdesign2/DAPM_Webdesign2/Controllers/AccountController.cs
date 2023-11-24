using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DAPM_Webdesign2.Models;
using DAPM_Webdesign2.ViewModels;

using DAPM_Webdesign2.Data;


namespace DAPM_Webdesign2.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ApplicationDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Login()
        {
            var resonse = new LoginViewModel();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel LoginViewModel)
        {
            if (!ModelState.IsValid) return View(LoginViewModel);

            var user = await _userManager.FindByEmailAsync(LoginViewModel.EmailAddress);

            if (user!= null)
            {
                // User is found, check password
                var passwordCheck = await _userManager.CheckPasswordAsync(user, LoginViewModel.Password);
                if (passwordCheck)
                {
                    // Password correct, sign in
                    var result = await _signInManager.PasswordSignInAsync(user, LoginViewModel.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Race");
                    }
                }
                // Password is incorrect
                TempData["Error"] = "Password is incorrect. Please, try again";
                return View(LoginViewModel);
            }
            // User not found
            TempData["Error"] = "User not found. Please try again";
            return View(LoginViewModel);
        }
    }
}
