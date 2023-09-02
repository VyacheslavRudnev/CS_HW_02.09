using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Oceanarium
    {
        public List<Pets> pets { get; set; }
        public Oceanarium()
        {
            pets = new List<Pets>();
        }
        public void Add(Pets pet)
        {
            pets.Add(pet);
        }
        public void Remove(Pets pet)
        {
            pets.Remove(pet);
        }
        public IEnumerator<Pets> GetEnumerator()
        {
            return pets.GetEnumerator();
        }
    }
}
