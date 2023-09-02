using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp020923
{
    public class Garage
    {
        public List<Car> Cars { get; set; }
        public Garage()
        {
            Cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }
        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
    }
}
