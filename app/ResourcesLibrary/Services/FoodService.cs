using ResourcesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesLibrary.Services
{
    public class FoodService
    {
        private List<Food> _food = new List<Food>
        {
            new Food {
                Id = 1,
                Name = "King Burger",
                Price = 250,
                Description = "best burger"
            },
            new Food {
                Id = 2,
                Name = "Cheese Burger",
                Price = 350,
                Description = "burger with cheese"
            },
            new Food {
                Id = 3,
                Name = "Big tasty",
                Price = 400,
                Description = "burger Big tasty"
            },
            new Food {
                Id = 4,
                Name = "Potato",
                Price = 150,
                Description = "Willage Potato"
            }
        };

        public Food Get(int id)
        {
            return _food.FirstOrDefault(x => x.Id == id);
        }

        public List<Food> GetAll()
        {
            return _food;
        }
    }
}
