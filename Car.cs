using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public Car(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public override string ToString()
        {
            return $"{Name}, {Model}";
        }
    }
}
