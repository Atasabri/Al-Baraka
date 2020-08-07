using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ALBaraka.Repositories.UnitOfWork;

namespace ALBaraka.Controllers
{
    public class ContactsController : Controller
    {
        private IUnitOfWork unitOfWork;

        public ContactsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View(unitOfWork.Contacts.AllData());
        }

        [HttpPost]
        public ActionResult SendMail(string Subject,IFormFile File,List<string> Emails)
        {
            unitOfWork.Emails.Send_Mail(Subject, File, Emails);
            return RedirectToAction(nameof(Index));
        }

    }
}