using System.Text;
using System.Collections;
namespace ConsoleApp020923
{
//Завдання 3
//Створіть клас «Гараж». Клас має містити інформацію
//про машини, які знаходяться в гаража.Створіть клас
//«Автомобіль», в якому, відповідно, міститься інформація
//про автомобіль.Реалізуйте підтримку ітератора для класу
//«Гараж». Протестуйте можливість використання foreach
//для класу «Гараж».
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/Mod10/Pract/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Перший варіант реалізації\n");
            Garage garage = new Garage();
            garage.AddCar(new Car("Audi", "A4"));
            garage.AddCar(new Car("BMW", "X5"));
            garage.AddCar(new Car("Mercedes", "S500"));
            garage.AddCar(new Car("Volkswagen", "Passat"));
            garage.AddCar(new Car("Skoda", "Octavia"));
            garage.AddCar(new Car("Opel", "Astra"));
            
            Console.WriteLine("Машини в гаражі №1:");
            foreach (Car car in garage)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            Console.WriteLine($"Видаляємо автомобіль {garage.Cars[1]}\n"); ;
            garage.RemoveCar(garage.Cars[1]);
            Console.WriteLine("Список машин в гаражі №1 після видалення:");
            foreach (Car car in garage)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Console.WriteLine("Другий варіант реалізації\n");
            List<Garage> garage2 = new List<Garage>();
            garage2.Add(new Garage());
            garage2[0].AddCar(new Car("Audi", "A4"));
            garage2[0].AddCar(new Car("BMW", "X5"));
            garage2[0].AddCar(new Car("Mercedes", "S500"));
            garage2[0].AddCar(new Car("Volkswagen", "Passat"));
            garage2[0].AddCar(new Car("Skoda", "Octavia"));
            garage2[0].AddCar(new Car("Opel", "Astra"));
            garage2.Add(new Garage());
            Console.WriteLine("Машини в гаражі №2:");
            foreach (Car car in garage2[0])
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            Console.WriteLine($"Видаляємо автомобіль {garage2[0].Cars[1]}\n"); ;
            garage2[0].RemoveCar(garage2[0].Cars[1]);
            Console.WriteLine("Список машин в гаражі №2 після видалення:");
            foreach (Car car in garage2[0])
            {
                Console.WriteLine(car);
            }
            
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}