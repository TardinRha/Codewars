//Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).
//The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.
//Mind the input validation.

namespace Sum_without_highest_and_lowest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces: ");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine($"Sum without highest and lowest number: {Kata.Sum(numbers)}");
        }
    }
    public static class Kata
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || numbers.Length <= 1)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum - (numbers.Min() + numbers.Max());
        }
    }
}