using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ResourcesLibrary.Models
{
    public class BreweryContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Event> Events { get; set; }
    }
}
