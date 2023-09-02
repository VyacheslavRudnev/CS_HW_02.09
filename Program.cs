using System.Text;
using System.Collections;
using System.Buffers;

namespace ConsoleApp020923
{
//Завдання 2
//Створіть клас «Будинок», в якому має міститися ін-
//формація про квартири в цьому будинку.Створіть клас
//«Квартира» з інформацією про мешканців квартир.Реалі-
//зуйте підтримку ітератора для класів «Будинок» і «Квар-
//тира». Протестуйте можливість використання foreach для
//класів «Будинок» і «Квартира».

    public class House
    {
        public int HouseNumber { get; set; }
        public List<Flat> flats { get; set; }
        public House(int houseNumber)
        {
            HouseNumber = houseNumber;
            flats = new List<Flat>();
        }
        public IEnumerator GetEnumerator()
        {
            return flats.GetEnumerator();
        }
    }
    public class Flat
    {
        public int FlatNumber { get; set; }
        public int Owner { get; set; }
        public List<Flat> Flats { get; set; }
        public Flat()
        {
            Flats = new List<Flat>();
        }
        public IEnumerator GetEnumerator()
        {
            return Flats.GetEnumerator();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/Mod10/P/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            //перший варіант
            //Dictionary<int, List<Flat>> house = new Dictionary<int, List<Flat>>();
            //house.Add(1, new List<Flat>());
            //house[1].Add(new Flat() { FlatNumber = 1, Owner = 1 });
            //house[1].Add(new Flat() { FlatNumber = 2, Owner = 2 });
            //house[1].Add(new Flat() { FlatNumber = 3, Owner = 3 });
            //house.Add(2, new List<Flat>());
            //house[2].Add(new Flat() { FlatNumber = 1, Owner = 1 });
            //house[2].Add(new Flat() { FlatNumber = 2, Owner = 2 });
            //house[2].Add(new Flat() { FlatNumber = 3, Owner = 3 });
            //Console.WriteLine("House 1");
            //foreach (var flat in house[1])
            //{
            //    Console.WriteLine($"Flat {flat.FlatNumber} Owner {flat.Owner}");
            //}
            //Console.WriteLine("House 2");
            //foreach (var flat in house[2])
            //{
            //    Console.WriteLine($"Flat {flat.FlatNumber} Owner {flat.Owner}");
            //}
            //Console.WriteLine("\n\nPress any key to exit...");
            //Console.ReadKey();

            //другий варіант
            List<House> houses = new List<House>();
            houses.Add(new House(1));
            houses[0].flats.Add(new Flat() { FlatNumber = 1, Owner = 1 });
            houses[0].flats.Add(new Flat() { FlatNumber = 2, Owner = 1 });
            houses[0].flats.Add(new Flat() { FlatNumber = 3, Owner = 2 });
            houses.Add(new House(2));
            houses[1].flats.Add(new Flat() { FlatNumber = 1, Owner = 2 });
            houses[1].flats.Add(new Flat() { FlatNumber = 2, Owner = 1 });
            houses[1].flats.Add(new Flat() { FlatNumber = 3, Owner = 1 });
            Console.WriteLine("House 1");
            foreach (var flat in houses[0].flats)
            {
                Console.WriteLine($"Flat {flat.FlatNumber} Owner {flat.Owner}");
            }
            Console.WriteLine("House 2");
            foreach (var flat in houses[1].flats)
            {
                Console.WriteLine($"Flat {flat.FlatNumber} Owner {flat.Owner}");
            }



        }
    }
}