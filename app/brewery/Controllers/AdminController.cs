using ResourcesLibrary.Models;
using ResourcesLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace brewery.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Beer item)
        {
            new AdminService().AddBeer(item);

            return RedirectToRoute(new
            {
                controller = "Beer",
                action = "Index",
            });
        }
    }
}