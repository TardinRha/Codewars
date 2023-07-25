//We want to generate a function that computes the series starting from 0 and ending until the given number.

namespace Sum_of_numbers_from_0_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            Console.WriteLine(SequenceSum.ShowSequence(int.Parse(Console.ReadLine())));
        }
    }
    public class SequenceSum
    {
        public static string ShowSequence(int n)
        {
            if (n > 0)
            {
                int sum = 0;
                string sequence = "";
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                    sequence += $"{i}";
                    if (i < n) { sequence += "+"; }
                }
                return $"{sequence} = {sum}";
            }
            return n < 0 ? $"{n} < 0" : "0 = 0";
        }
    }
}