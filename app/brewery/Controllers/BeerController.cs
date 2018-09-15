using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace brewery.Controllers
{
    public class BeerController : Controller
    {
        // GET: Beer
        public ActionResult Index()
        {
            return View();
        }
    }
}