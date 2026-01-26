using Microsoft.AspNetCore.Mvc;
using BuissnessLogicLayer;

namespace CORNY.Controllers
{
    public class FarmController : Controller
    {
        private readonly IFarmService farmService;
        public FarmController(IFarmService farmService)
        {
            this.farmService = farmService;
        }

        public async Task<IActionResult> Index()
        {
            var farms = await farmService.GetFarmsAsync();
            return View(farms);
        }
    }
}
