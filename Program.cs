using System.Text;
using System.Collections;
namespace ConsoleApp020923
{
//Завдання 1
//Створіть клас «Алфавіт», в якому мають міститися
//літери англійського алфавіту.Реалізуйте підтримку іте -
//ратора.Протестуйте можливість використання foreach
//для класу «Алфавіт».

    public class Alphabet
    {
        List<char> alphabet = new List<char>();
        public Alphabet()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                alphabet.Add(i);
            }
        }
        public IEnumerator GetEnumerator()
        {
            return alphabet.GetEnumerator();
        }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/Mod10/Pract/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Alphabet alphabet = new Alphabet();
            foreach (char letter in alphabet)
            {
                Console.Write(letter + " ");
            }
            
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}