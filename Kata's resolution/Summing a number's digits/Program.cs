//Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits. For example: (Input-- > Output)

namespace Summing_a_number_s_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of digits: {Kata.SumDigits(number)}");
        }
    }
    public class Kata
    {
        public static int SumDigits(int number)
        {
            string numero = number.ToString().Replace("-", "");
            int soma = 0;
            foreach (char n in numero)
            {
                soma += int.Parse(n.ToString());
            }
            return soma;
        }
    }
}