using Microsoft.AspNetCore.Mvc;
using ShardsOfMonolith.Core.Dto;
using ShardsOfMonolith.Core.ServiceInterface;
using ShardsOfMonolith.Data;
using ShardsOfMonolith.Models.Stalker;

namespace ShardsOfMonolith.Controllers
{
    public class StalkersController : Controller
    {
        /*
         * StalkerController controls all functions for stalker, including, missinons 
         */
        private readonly ShardsOfMonolithContext _context;
        private readonly IStalkersServices _stalkerServices;

        public StalkersController(ShardsOfMonolithContext context, IStalkersServices stalkerServices)
        {
            _context = context;
            _stalkerServices = stalkerServices;

        }
        public IActionResult Index()
        {
            var resultingInventory = _context.Stalkers
                .OrderByDescending (y => y.StalkerLevel)
                .Select( x => new StalkerIndexViewModel
                {
                    ID = x.ID,
                    StalkerName = x.StalkerName,
                    StalkerType = (StalkerType)x.StalkerType,
                    StalkerLevel = x.StalkerLevel,
                });
            return View(resultingInventory);


            
        }
        [HttpGet]
        public IActionResult Create()
        {
            StalkerCreateViewModel vm = new();
            return View("Create",vm);
        }
        [HttpPost]
        public async Task <IActionResult> Create(StalkerCreateViewModel vm)
        {
            var dtb = new StalkerDto()
            {
                StalkerName =vm.StalkerName,
                StalkerHealth = 100,
                StalkerXP = 0,
                StalkerXPNextLevel = 100,
                StalkerLevel = 0,
                StalkerType = (Core.Dto.StalkerType)(vm.StalkerType),
                StalkerStatus = (Core.Dto.StalkerStatus)(vm.StalkerStatus)
                PrimaryAttackName = vm.PrimaryAttackName)(vm.StalkerName),



            }
        }
        

    }
}
