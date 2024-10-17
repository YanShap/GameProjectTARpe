using Microsoft.AspNetCore.Mvc;
using ShardsOfMonolith.Date;

namespace ShardsOfMonolith.Controllers
{
    public class StalkersController : Controller
    {
        /*
         * StalkerController controls all functions for stalker, including, missinons 
         */
        private readonly ShardsOfMonolithContext _context;
        private readonly IStalkerServices _stalkerServices;

        public StalkersController(ShardsOfMonolithContext context, IStalkerServices stalkerServices)
        {
            _context = context;
            _stalkerServices = stalkerServices

        }
        public IActionResult Index()
        {
            var resultingInventory = _context.Stalkers
                .OrderByDescending (y => y.StalkerLevel)
                .Select( x => new StalkerIndexViewModel
                {
                    ID = x.ID,
                    StalkerName = x.StalkerName,
                    StalkerType = x.StalkerType,
                    StalkerLevel = x.StalkerLevel,
                });
            return View();
        }
    }
}
