using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Dish
    {
        public string DishName { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public Dish(string dishName, string type, double price)
        {
            DishName = dishName;
            Type = type;
            Price = price;
        }
        public override string ToString()
        {
            return $"{DishName}, вартість {Price} грн";
        }
        public IEnumerator<Dish> GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
