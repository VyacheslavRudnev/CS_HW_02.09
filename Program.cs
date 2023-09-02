using System.Text;
namespace ConsoleApp020923
{
    internal class Program
    {
        static void Main(string[] args)
        {

//Завдання 2
//Створіть клас «Футбольна Команда». Клас має містити
//інформацію про гравців футбольної команди. Реалізуйте
//підтримку ітератора для класу «Футбольна Команда».
//Протестуйте можливість використання foreach для класу
//«Футбольна Команда».

            Console.WriteLine("HW/Mod10/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            List<FootballTeam> teams = new List<FootballTeam>();
            teams.Add(new FootballTeam("Динамо"));
            teams[0].Players.Add(new TeamPlayer("Шовковський", 1, "Goalkeeper"));
            teams[0].Players.Add(new TeamPlayer("Петров", 2, "Defender"));
            teams[0].Players.Add(new TeamPlayer("Миколенко", 3, "Defender"));
            teams[0].Players.Add(new TeamPlayer("Караваєв", 4, "Defender"));
            teams[0].Players.Add(new TeamPlayer("Сидорчук", 5, "Midfielder"));
            teams[0].Players.Add(new TeamPlayer("Шепелєв", 6, "Midfielder"));
            teams[0].Players.Add(new TeamPlayer("Шапаренко", 7, "Midfielder"));
            teams[0].Players.Add(new TeamPlayer("Тимчик", 8, "Midfielder"));
            teams[0].Players.Add(new TeamPlayer("Буяльський", 9, "Midfielder"));
            teams[0].Players.Add(new TeamPlayer("Ванат", 10, "Forward"));
            teams[0].Players.Add(new TeamPlayer("Ярмоленко", 11, "Midfielder"));
            Console.WriteLine("Команда: " + teams[0].TeamName);
            Console.WriteLine("Гравці:");
            foreach (TeamPlayer player in teams[0])
            {
                Console.WriteLine(player.Name + " " + player.Number + " " + player.Description);
            }
            Console.WriteLine();
            teams[0].Players.Add(new TeamPlayer("Бєсєдін", 12, "Forward"));
            Console.WriteLine($"Заміна: {teams[0].Players[10].Name} йде, {teams[0].Players[11].Name} заходить");
            teams[0].Players.RemoveAt(10);
            Console.WriteLine("Гравці:");
            foreach (TeamPlayer player in teams[0])
            {
                Console.WriteLine(player.Name + " " + player.Number + " " + player.Description);
            }


        }
    }
}