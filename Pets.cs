using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Pets
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public Pets(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}
