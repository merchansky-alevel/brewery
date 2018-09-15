using ResourcesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesLibrary.Services
{
    public class EventsService
    {
        private List<Event> _events = new List<Event>
        {
            new Event {
                Id =1,
                Name = "Men's day",
                Price = 100,
                Date = DateTime.Parse("Feb 23, 2019")
            }
        };

        public Event Get(int id)
        {
            return _events.FirstOrDefault(x => x.Id == id);
        }
    }
}
