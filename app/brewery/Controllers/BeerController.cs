using ResourcesLibrary.Models;
using ResourcesLibrary.Services;
using System.Linq;
using System.Web.Mvc;

namespace brewery.Controllers
{
    public class BeerController : Controller
    {

        BreweryContext db = new BreweryContext();
        // GET: Beer
        public ActionResult Index() => View(db.Beers);

        [HttpGet]
        public ActionResult GetItem(int id)
        {
            var beerItem = new BeerService().Get(id);
            
            return View(beerItem);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}