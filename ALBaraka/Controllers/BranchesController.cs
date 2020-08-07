using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ALBaraka.Models;
using ALBaraka.Repositories.UnitOfWork;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALBaraka.Controllers
{
    public class BranchesController : Controller
    {
        private IUnitOfWork unitOfWork;
        private IHostingEnvironment hostingEnvironment;

        public BranchesController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Branchs
        public IActionResult Index()
        {
            return View(unitOfWork.Branchs.AllData());
        }

        // GET: Branchs/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = unitOfWork.Branchs.Find(id.Value);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // GET: Branchs/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Name,Name_EN,Map,WhatsApp,Phone,Email")] Branch branch, IFormFile Photo)
        {
            if (ModelState.IsValid && Photo != null)
            {
                unitOfWork.Branchs.AddOrUpdate(branch);
                unitOfWork.Save();
                Photo.CopyTo(new FileStream(hostingEnvironment.WebRootPath + "/Uploads/Branches/" + branch.ID.ToString() + ".jpg", FileMode.Create));
                return RedirectToAction(nameof(Index));
            }
            return View(branch);
        }

        // GET: Branchs/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = unitOfWork.Branchs.Find(id.Value);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ID,Name,Name_EN,Map,WhatsApp,Phone,Email")] Branch branch, IFormFile Photo)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Branchs.AddOrUpdate(branch);
                unitOfWork.Save();
                if (Photo != null)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Photo.CopyTo(new FileStream(hostingEnvironment.WebRootPath + "/Uploads/Branches/" + branch.ID.ToString() + ".jpg", FileMode.Create));
                }
                return RedirectToAction(nameof(Index));
            }
            return View(branch);
        }

        // GET: Branchs/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = unitOfWork.Branchs.Find(id.Value);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // POST: Branchs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var branch = unitOfWork.Branchs.Find(id);
            unitOfWork.Branchs.Delete(branch);
            unitOfWork.Save();
            FileInfo Photo = new FileInfo(hostingEnvironment.WebRootPath + "/Uploads/Branches/" + id.ToString() + ".jpg");
            if (Photo.Exists)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Photo.Delete();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}