using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp020923
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 3
//Створіть клас «Кафе» з інформацією про праців-
//ників кафе.Реалізуйте підтримку ітератора для класу
//«Кафе». Протестуйте можливість використання foreach
//для «Кафе».

            Console.WriteLine("HW/Mod10/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Перший варіант реалізації\n");
            List<Cafe> cafe = new List<Cafe>();
            cafe.Add(new Cafe("CoffeGeyser"));
            cafe[0].AddEmployee(new Employee("Василь", "Бариста"));
            cafe[0].AddEmployee(new Employee("Петро Васильович", "Власник"));
            cafe[0].AddEmployee(new Employee("Іван", "Бариста"));
            cafe[0].AddEmployee(new Employee("Марія", "Офіціант"));
            cafe[0].AddEmployee(new Employee("Олександр", "Електрик"));
            cafe[0].AddEmployee(new Employee("Олег", "Постачальник"));
            Console.WriteLine($"Кафе: {cafe[0].Name}");
            Console.WriteLine("Список працівників:");
            foreach (var item in cafe[0])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Другий варіант реалізації\n");
            Dictionary<string, List<Employee>> cafe2 = new Dictionary<string, List<Employee>>();
            cafe2.Add("CoffeGeyser 2.0", new List<Employee>());
            cafe2["CoffeGeyser 2.0"].Add(new Employee("Василь", "Бариста"));
            cafe2["CoffeGeyser 2.0"].Add(new Employee("Петро Васильович", "Власник"));
            cafe2["CoffeGeyser 2.0"].Add(new Employee("Іван", "Кухар"));
            cafe2["CoffeGeyser 2.0"].Add(new Employee("Марія", "Офіціант"));
            Console.WriteLine($"Кафе: {cafe2.Keys.First()}");
            Console.WriteLine("Список працівників:");
            foreach (var item in cafe2.Values.First())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nРозширений варіант реалізації\n");
            //не доробив одразу, тому не зовсім пам'ятаю, що конкретно задумав зробити для цього варіанту
            Dictionary<string, Dictionary<string, List<Menu>>> keyValuePairs = new Dictionary<string, Dictionary<string, List<Menu>>>();
            keyValuePairs.Add("CoffeGeyser 3.0", new Dictionary<string, List<Menu>>());
            keyValuePairs["CoffeGeyser 3.0"].Add("Кухня", new List<Menu>());
            keyValuePairs["CoffeGeyser 3.0"].Add("Бар", new List<Menu>());
            keyValuePairs["CoffeGeyser 3.0"]["Кухня"].Add(new Menu("Борщ", 105));
            keyValuePairs["CoffeGeyser 3.0"]["Кухня"].Add(new Menu("Суп", 68));
            keyValuePairs["CoffeGeyser 3.0"]["Кухня"].Add(new Menu("Пюре",50));
            keyValuePairs["CoffeGeyser 3.0"]["Бар"].Add(new Menu("Кава",25));
            keyValuePairs["CoffeGeyser 3.0"]["Бар"].Add(new Menu("Чай",15));
            keyValuePairs["CoffeGeyser 3.0"]["Бар"].Add(new Menu("Компот",10));
            if (keyValuePairs.Count > 0)
            {
                Console.WriteLine($"Кафе: {keyValuePairs.Keys.First()}");
                Console.WriteLine("Список меню:");

                var firstMenu = keyValuePairs.Values.First();

                foreach (var item in firstMenu)
                {
                    foreach (var item2 in item.Value)
                    {
                        Console.WriteLine(item2);
                    }
                }
            }
            else
            {
                Console.WriteLine("Словник порожній.");
            }
            Console.WriteLine("\nЩе один варіант реалізації\n");
            Dictionary<string, List<Employee>> cafe5 = new Dictionary<string, List<Employee>>();
            cafe5.Add("CoffeGeyser 5.0", new List<Employee>());
            cafe5["CoffeGeyser 5.0"].Add(new Employee("Василь", "Бариста"));
            Dictionary<string, List<Menu>> menu = new Dictionary<string, List<Menu>>();
            menu.Add("Кухня", new List<Menu>());
            menu["Кухня"].Add(new Menu("Борщ", 105));
            menu["Кухня"].Add(new Menu("Суп", 68));
            menu["Кухня"].Add(new Menu("Пюре", 50));
            menu.Add("Бар", new List<Menu>());
            menu["Бар"].Add(new Menu("Кава", 25));
            menu["Бар"].Add(new Menu("Чай", 15));
            menu["Бар"].Add(new Menu("Компот", 10));
            cafe5["CoffeGeyser 5.0"].Add(new Employee("Іван", "Кухар"));
            cafe5["CoffeGeyser 5.0"].Add(new Employee("Марія", "Офіціант"));
            Console.WriteLine($"Кафе: {cafe5.Keys.First()}");
            Console.WriteLine("Список працівників:");
            foreach (var item in cafe5.Values.First())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nСписок меню:");
            foreach (var item in menu.Values)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
            Console.WriteLine("\nДодавання нових позицій до меню: Кухня - картопля, Бар - Кава з молоком");
            menu["Кухня"].Add(new Menu("Картопля", 30));
            menu["Бар"].Add(new Menu("Кава з молоком", 30));
            Console.WriteLine("\nСписок меню після додавання нових позицій:");
            foreach (var item in menu.Values)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
            Console.WriteLine("\nВидалення позицій з меню: Кухня - пюре, Бар - компот");
            menu["Кухня"].RemoveAt(2);//видаляємо пюре
            menu["Бар"].RemoveAt(2);//видаляємо компот
            Console.WriteLine("\nСписок меню після видалення позицій:");
            foreach (var item in menu.Values)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
            Console.WriteLine("\nСортування меню по ціні:");
            foreach (var item in menu.Values)
            {
                Console.WriteLine();
                foreach (var item2 in item.OrderBy(Cost => Cost.Cost))
                {
                    Console.WriteLine(item2);
                }
            }




        }
    }
}