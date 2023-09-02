using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class TeamPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public TeamPlayer(string name, int number, string description)
        {
            Name = name;
            Number = number;
            Description = description;
        }
    }
}
