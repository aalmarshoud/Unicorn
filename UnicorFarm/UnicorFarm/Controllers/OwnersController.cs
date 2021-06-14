using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unicore.Services.Entities;
using Unicore.Services.Services;

namespace UnicorFarm.Controllers
{
    public class OwnersController : Controller
    {
        private readonly IOwner ownerService;
        public OwnersController(IServiceProvider serviceProvider)
        {
            ownerService = serviceProvider.GetRequiredService<IOwner>();
        }
        public async Task<IActionResult> Index()
        {
            var model = await ownerService.Get();
            return View(model.ToList());
        }

        public async Task<IActionResult> AddEditOwnerView(int id)
        {
            Owner model = new Owner();
            if (id > 0)
            {
                var current = await ownerService.Get(id);
                model = current;
            }
            return View(model);
        }

        public async Task<IActionResult> SaveData(Owner data)
        {
            if (data.Id > 0)
            {
                await ownerService.Update(data);
            }
            else
            {
                await ownerService.Create(data);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await ownerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
