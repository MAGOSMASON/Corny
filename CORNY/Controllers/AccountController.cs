using Microsoft.AspNetCore.Mvc;
using CORNY.Models.ViewModels;

namespace CORNY.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO (Leah later): SignIn logic with Identity
            // For now: just pretend login succeeded
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (model.AcceptTerms != true)
            {
                ModelState.AddModelError(nameof(model.AcceptTerms),
                    "You must accept the Terms and Privacy Policy.");
            }

            if (!ModelState.IsValid)
                return View(model);

            return RedirectToAction("Login");
        }


    }
}
