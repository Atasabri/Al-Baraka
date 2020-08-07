using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ALBaraka.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ALBaraka.Controllers
{
    public class StaticDataController : Controller
    {
        private readonly DB db;
        private readonly IHostingEnvironment hostingEnvironment;

        public StaticDataController(DB db,IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View(db.StaticData.Where(x=>x.Type != (int)Types.Image).ToList());
        }
        [HttpPost]
        public ActionResult EditData(List<StaticData> Data)
        {
            foreach (var item in Data)
            {
                db.StaticData.Update(item);
            }
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult IndexImages()
        {
            return View(db.StaticData.Where(x => x.Type == (int)Types.Image).ToList());
        }

        [HttpPost]
        public ActionResult EditStaticImages()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            foreach (var item in Request.Form.Files)
            {
                string extention = Path.GetExtension(item.FileName);
                StaticData row = db.StaticData.SingleOrDefault(x => x.Key == item.Name);
                row.Value = item.Name + extention;
                item.CopyTo(new FileStream(hostingEnvironment.WebRootPath+"/Uploads/StaticImages/"+row.Value,FileMode.Create));
                db.StaticData.Update(row);
            }
            db.SaveChanges();
            return RedirectToAction(nameof(IndexImages));
        }
    }
}