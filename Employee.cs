using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public List<Menu> Menus { get; set; }
        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }
        public Employee(string name, string position, List<Menu> menus)
        {
            Name = name;
            Position = position;
            Menus = menus;
        }

        public void AddMenu(Menu menu)
        {
            Menus.Add(menu);
        }
        public void RemoveMenu(Menu menu)
        {
            Menus.Remove(menu);
        }
        public override string ToString()
        {
            return $"{Name}, {Position}";
        }
        public IEnumerator<Menu> GetEnumerator()
        {
            return Menus.GetEnumerator();
        }
    }
}
