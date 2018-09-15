using ResourcesLibrary.Models;
using ResourcesLibrary.Services;
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
            var beerList = new BeerService().GetAll();

            return View(beerList);
        }

        [HttpGet]
        public ActionResult GetItem(int id)
        {
            var beerItem = new BeerService().Get(id);
            
            return View(beerItem);
        }
    }
}