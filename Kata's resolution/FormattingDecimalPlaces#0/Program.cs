//Each number should be formatted that it is rounded to two decimal places.
//You don't need to check whether the input is a valid number because only valid numbers are used in the tests.

using System.Globalization;
namespace FormattingDecimalPlaces_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            Console.WriteLine(Numbers.TwoDecimalPlaces(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)));
        }
    }
    public class Numbers
    {
        public static double TwoDecimalPlaces(double number)
        {
            return double.Parse(number.ToString("F2"));
        }
    }
}