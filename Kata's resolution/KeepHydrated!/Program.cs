//Nathan loves cycling.
//Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
//You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.
using System.Globalization;
namespace KeepHydrated_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many hours to be pedaled? ");
            Console.WriteLine($"The number of liters that should be drunk is: {Kata.Litres(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture))}");
        }
    }
    public class Kata
    {
        public static int Litres(double time)
        {
            return (int)time / 2;
        }
    }
}