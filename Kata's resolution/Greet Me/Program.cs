//Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

namespace Greet_Me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome para saudar: ");
            Console.WriteLine(Kata.Greet(Console.ReadLine()));
        }
    }
    public static class Kata
    {
        public static string Greet(string name)
        {
            name = name.ToLower();
            string nome = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 0) { nome += char.ToUpper(name[i]); }
                else { nome += name[i]; }
            }
            return $"Hello {nome}!";
        }
    }
}