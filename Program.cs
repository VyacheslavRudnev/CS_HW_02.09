using System.Text;
namespace ConsoleApp020923
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 1
//Створіть клас «Океанаріум» з інформацією про «меш -
//канців» Океанаріуму.Створіть клас для кожної істоти
//Океанаріуму.Вони мають містити інформацію про кожну
//морську істоту. Реалізуйте підтримку ітератора для класу
//«Океанаріум». Протестуйте можливість використання
//foreach для Океанаріуму.

            Console.WriteLine("HW/Mod10/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Перший варіант реалізації");
            Console.ResetColor();
            Oceanarium oceanarium = new Oceanarium();
            oceanarium.Add(new Pets("Dolphin", "Mammal", 5));
            oceanarium.Add(new Pets("Shark", "Fish", 10));
            oceanarium.Add(new Pets("Turtle", "Reptile", 15));
            oceanarium.Add(new Pets("Octopus", "Mollusk", 20));
            oceanarium.Add(new Pets("Crab", "Arthropod", 25));
            oceanarium.Add(new Pets("Squid", "Mollusk", 30));
            oceanarium.Add(new Pets("Seahorse", "Fish", 35));
            oceanarium.Add(new Pets("Jellyfish", "Mollusk", 40));
            oceanarium.Add(new Pets("Starfish", "Echinoderm", 45));
            Console.WriteLine("Oceanarium contains:");
            foreach (Pets pet in oceanarium)
            {
                Console.WriteLine($"{pet.Name} - {pet.Type} - {pet.Age}");
            }
            Console.WriteLine();
            Console.WriteLine($"Звільнення мешканця {oceanarium.pets[0].Name}\n");
            oceanarium.Remove(oceanarium.pets[0]);
            Console.WriteLine("Oceanarium contains:");
            foreach (Pets pet in oceanarium)
            {
                Console.WriteLine($"{pet.Name} - {pet.Type} - {pet.Age}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nДругий варіант реалізації");
            Console.ResetColor();
            List<Oceanarium> oceanarium2 = new List<Oceanarium>();
            oceanarium2.Add(new Oceanarium());
            oceanarium2[0].Add(new Pets("Dolphin", "Mammal", 5));
            oceanarium2[0].Add(new Pets("Shark", "Fish", 10));
            oceanarium2[0].Add(new Pets("Turtle", "Reptile", 15));
            oceanarium2[0].Add(new Pets("Octopus", "Mollusk", 20));
            oceanarium2[0].Add(new Pets("Crab", "Arthropod", 25));
            oceanarium2[0].Add(new Pets("Squid", "Mollusk", 30));
            oceanarium2[0].Add(new Pets("Seahorse", "Fish", 35));
            oceanarium2[0].Add(new Pets("Jellyfish", "Mollusk", 40));
            oceanarium2[0].Add(new Pets("Starfish", "Echinoderm", 45));
            Console.WriteLine("Oceanarium contains:");
            foreach (Pets pet in oceanarium2[0])
            {
                Console.WriteLine($"{pet.Name} - {pet.Type} - {pet.Age}");
            }
            Console.WriteLine();
            Console.WriteLine($"Звільнення мешканця {oceanarium2[0].pets[2].Name}\n");
            oceanarium2[0].Remove(oceanarium2[0].pets[2]);
            Console.WriteLine("Oceanarium contains:");
            foreach (Pets pet in oceanarium2[0])
            {
                Console.WriteLine($"{pet.Name} - {pet.Type} - {pet.Age}");
            }
        }
    }
}