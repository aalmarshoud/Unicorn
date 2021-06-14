using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Unicore.Services.Dtos;
using Unicore.Services.Extentions;
using Unicore.Services.Services;
using UnicorFarm.Models;

namespace UnicorFarm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnicoreFarm unicornService;
        private readonly IOwner ownerService;
        public HomeController(IServiceProvider serviceProvider,ILogger<HomeController> logger)
        {
            _logger = logger;
            unicornService = serviceProvider.GetRequiredService<IUnicoreFarm>();
            ownerService = serviceProvider.GetRequiredService<IOwner>();
        }

        public async Task<IActionResult> Index()
        {
            var model = await unicornService.Get();
            var currentmodel = model.Select(p => new UnicoreInfoVM 
            {
                ID = p.Id,
                UnicoreName = p.UnicoreName,
                UnicoreDescription = p.Description,
                OwnerName = p.Owner.Name,
                Mobile = p.Owner.Mobile
            }).ToList();
            return View(currentmodel);
        }

        public async Task<IActionResult>AddEditUnicorView(int id)
        {
            UnicoreInfoVM model = new UnicoreInfoVM();
            if (id > 0)
            {
                var current = await unicornService.Get(id);
                model = new UnicoreInfoVM
                {
                    ID = current.Id,
                    UnicoreName = current.UnicoreName,
                    UnicoreDescription = current.Description,
                    OwnerId = current.OwnerId,
                    OwnerName = current.Owner.Name,
                    Mobile = current.Owner.Mobile
                };
            }
            //get owner as drop down list
            var owners = await ownerService.Get();
            ViewBag.Owners = owners.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            }).ToList();
            return View(model);
        }

        public async Task<IActionResult> SaveData(UnicoreInfoVM data)
        {
            if (data.ID > 0)
            {
                await unicornService.Update(data.ToEntity());
            }
            else
            {
                await unicornService.Create(data.ToEntity());
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detele(int id)
        {
            await unicornService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
