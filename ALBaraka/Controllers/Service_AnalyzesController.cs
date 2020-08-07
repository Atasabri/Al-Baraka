using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ALBaraka.Models;
using ALBaraka.Repositories.UnitOfWork;

namespace ALBaraka.Controllers
{
    public class Service_AnalyzesController : Controller
    {
        private IUnitOfWork unitOfWork;

        public Service_AnalyzesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: Service_Analyzes
        public IActionResult Index(int Service_ID)
        {
            ViewBag.Service_ID = Service_ID;
            ViewBag.Service_Name = unitOfWork.Services.Find(Service_ID).Name;
            return View(unitOfWork.Service_Analyze.FindData(x=>x.Service_ID==Service_ID));
        }

        // GET: Service_Analyzes/Create
        public IActionResult Create(int Service_ID)
        {
            ViewBag.Service_ID = Service_ID;
            ViewBag.Service_Name = unitOfWork.Services.Find(Service_ID).Name;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Service_Analyzes service_Analyzes)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Service_Analyze.AddOrUpdate(service_Analyzes);
                unitOfWork.Save();
                return RedirectToAction(nameof(Index),new { Service_ID = service_Analyzes.Service_ID});
            }
            return View(service_Analyzes);
        }

        // GET: Service_Analyzes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service_Analyzes = unitOfWork.Service_Analyze.Find(id.Value);
            if (service_Analyzes == null)
            {
                return NotFound();
            }
            return View(service_Analyzes);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Service_Analyzes service_Analyzes)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Service_Analyze.AddOrUpdate(service_Analyzes);
                unitOfWork.Save();
                return RedirectToAction(nameof(Index), new { Service_ID = service_Analyzes.Service_ID });
            }
            return View(service_Analyzes);
        }


        [HttpPost]
        public JsonResult DeleteAnalyze(int ID)
        {
            Service_Analyzes service_Analyzes = unitOfWork.Service_Analyze.Find(ID);
            unitOfWork.Service_Analyze.Delete(service_Analyzes);
            unitOfWork.Save();

            return Json(ID);
        }

    }
}
