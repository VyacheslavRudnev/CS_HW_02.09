using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Cafe
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public Cafe(string name)
        {
            Employees = new List<Employee>();
            Name = name;
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        public IEnumerator<Employee> GetEnumerator()
        {
            return Employees.GetEnumerator();
        }
    }
}
