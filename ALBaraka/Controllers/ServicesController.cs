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
    public class ServicesController : Controller
    {
        private IUnitOfWork unitOfWork;
        private IHostingEnvironment hostingEnvironment;

        public ServicesController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment)
        {
            this.unitOfWork = unitOfWork;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Services
        public IActionResult Index()
        {
            return View(unitOfWork.Services.AllData());
        }

        // GET: Services/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = unitOfWork.Services.Find(id.Value);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Name,Description,Name_EN,Description_EN")] Service service, IFormFile Photo)
        {
            if (ModelState.IsValid && Photo != null)
            {
                unitOfWork.Services.AddOrUpdate(service);
                unitOfWork.Save();
                Photo.CopyTo(new FileStream(hostingEnvironment.WebRootPath + "/Uploads/Services/" + service.ID.ToString() + ".jpg", FileMode.Create));
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // GET: Services/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = unitOfWork.Services.Find(id.Value);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ID,Name,Description,Name_EN,Description_EN")] Service service, IFormFile Photo)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Services.AddOrUpdate(service);
                unitOfWork.Save();
                if (Photo != null)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Photo.CopyTo(new FileStream(hostingEnvironment.WebRootPath + "/Uploads/Services/" + service.ID.ToString() + ".jpg", FileMode.Create));
                }
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // GET: Services/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = unitOfWork.Services.Find(id.Value);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var Service = unitOfWork.Services.Find(id);
            unitOfWork.Services.Delete(Service);
            unitOfWork.Save();
            FileInfo Photo = new FileInfo(hostingEnvironment.WebRootPath + "/Uploads/Services/" + id.ToString() + ".jpg");
            if (Photo.Exists)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Photo.Delete();
            }
            return RedirectToAction(nameof(Index));
        }


        public ActionResult Comments(int Service_ID)
        {
            List<Comment> comments = unitOfWork.Comments.FindData(comment => comment.Service_ID == Service_ID).ToList();
            ViewBag.ServiceName = unitOfWork.Services.Find(Service_ID).Name;
            return View(comments);
        }

        [HttpPost]
        public JsonResult DeleteComment(int ID)
        {
            Comment comment = unitOfWork.Comments.Find(ID);
            unitOfWork.Comments.Delete(comment);
            unitOfWork.Save();

            return Json(ID);
        }
    }
}