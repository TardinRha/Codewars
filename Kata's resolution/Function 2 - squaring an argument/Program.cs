//Now you have to write a function that takes an argument and returns the square of it.

namespace Function_2___squaring_an_argument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine($"Square of the number: {Kata.Square(number)}");
        }
    }
    public class Kata
    {
        public static double Square(double n)
        {
            return n * n;
        }
    }
}