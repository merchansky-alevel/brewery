using ResourcesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesLibrary.Services
{
    public class AdminService
    {
        BreweryContext context = new BreweryContext();

        public void AddBeer(Beer beer)
        {
            context.Beers.Add(beer);

            context.SaveChanges();
        }
    }
}
