//Create a function that converts US dollars (USD) to Chinese Yuan (CNY) .
//The input is the amount of USD as an integer, and the output should be a string that states
// the amount of Yuan followed by 'Chinese Yuan'.

using System.Globalization;
namespace USD___CNY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount in USD: ");
            Console.WriteLine(Kata.Usdcny(int.Parse(Console.ReadLine())));
        }
    }
    public static class Kata
    {
        public static string Usdcny(int usd)
        {
            return $"{(usd * 6.75).ToString("F2", CultureInfo.InvariantCulture)} Chinese Yuan";
        }
    }
}