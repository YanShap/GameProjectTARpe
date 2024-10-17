using Microsoft.AspNetCore.Mvc;

namespace ShardsOfMonolith.Controllers
{
    public class StalkerController : Controller
    {
        /*
         * Stalker Controller 
         */
        public IActionResult Index()
        {
            return View();
        }
    }
}
