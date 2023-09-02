﻿using System;
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
        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }
        public override string ToString()
        {
            return $"{Name}, {Position}";
        }
    }
}
