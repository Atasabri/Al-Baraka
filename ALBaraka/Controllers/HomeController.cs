using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ALBaraka.Models;
using ALBaraka.Repositories.UnitOfWork;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.EntityFrameworkCore;

namespace ALBaraka.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IStringLocalizer<HomeController> localizer;

        public HomeController(IUnitOfWork unitOfWork, IStringLocalizer<HomeController> localizer)
        {
            this.unitOfWork = unitOfWork;
            this.localizer = localizer;
        }
        public IActionResult Index()
        {
            List<Branch> branches = unitOfWork.Branchs.AllData().ToList();
            return View(branches);
        }

        public IActionResult About()
        {
            List<Service> services = unitOfWork.Services.AllData().ToList();
            return View(services);
        }

        public IActionResult Images()
        {
            return View(unitOfWork.Images.AllData());
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(Contact contact)
        {
            unitOfWork.Contacts.AddOrUpdate(contact);
            unitOfWork.Save();
            ViewBag.Done = localizer["Thanks For Contact , We Will Call You ."].Value;
            return View();
        }

        public IActionResult Services()
        {
            var services = unitOfWork.Services.AllData();
            return View(services);
        }

        public IActionResult Service(int ID)
        {
            Service service = unitOfWork.Services.GetServiceInclude(ID);
            return View(service);
        }

        public IActionResult Branches()
        {
            var branches = unitOfWork.Branchs.AllData();
            return View(branches);
        }

        [HttpPost]
        public JsonResult Comment(Comment comment)
        {
            unitOfWork.Comments.AddOrUpdate(comment);
            unitOfWork.Save();

            return Json(new {comment.Name,comment.YourComment });
        }

        [HttpPost]
        public JsonResult Subscribe(string Email)
        {
            unitOfWork.Subscripers.AddOrUpdate(new Subscriber { Email = Email});
            unitOfWork.Save();
            return Json(localizer["Thank You For Subscribe ."].Value);
        }

        public IActionResult SetLanguage(string culture)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(1) }
            );
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public ActionResult Follow()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}