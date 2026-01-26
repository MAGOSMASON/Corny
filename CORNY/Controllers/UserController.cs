using BuissnessLogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace CORNY.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public async Task<IActionResult> Index()
        {
            var users = await userService.GetUsersAsync();
            return View(users);
        }
    }
}
