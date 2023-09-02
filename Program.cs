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


        }
    }
}