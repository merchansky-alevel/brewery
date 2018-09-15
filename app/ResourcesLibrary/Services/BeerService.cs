using ResourcesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesLibrary.Services
{
    public class BeerService
    {
        public List<Beer> _beers = new List<Beer>
        {
            new Beer {
                Id = 1,
                Name = "Chernigov",
                Price = 100,
                Description = "Some description"
            },
            new Beer {
                Id = 2,
                Name = "Obolon",
                Price = 120,
                Description = "Some description Obolon"
            },
            new Beer {
                Id = 3,
                Name = "Baltica 9",
                Price = 200,
                Description = "The best beer"
            }
        };

        public Beer Get(int id)
        {
            return _beers.FirstOrDefault(x => x.Id == id);
        }

        public List<Beer> GetAll()
        {
            return _beers;
        }
    }
}
