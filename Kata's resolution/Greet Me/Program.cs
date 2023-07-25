//Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

namespace Greet_Me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name to greet: ");
            Console.WriteLine(Kata.Greet(Console.ReadLine()));
        }
    }
    public static class Kata
    {
        public static string Greet(string name)
        {
            name = name.ToLower();
            string greeting = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 0) { greeting += char.ToUpper(name[i]); }
                else { greeting += name[i]; }
            }
            return $"Hello {greeting}!";
        }
    }
}