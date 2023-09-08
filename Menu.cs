using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Menu
    {
        public string TypeName { get; set; }
        public int Cost { get; set; }
        public List<Dish> Dishes { get; set; }
        public Menu(string name, int cost)
        {
            Dishes = new List<Dish>();
            TypeName = name;
            Cost = cost;
        }
        
        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            Dishes.Remove(dish);
        }
        public override string ToString()
        {
            return $"{TypeName}, вартість {Cost} грн.";
        }
        public IEnumerator<Dish> GetEnumerator()
        {
            return Dishes.GetEnumerator();
        }
    }
}
