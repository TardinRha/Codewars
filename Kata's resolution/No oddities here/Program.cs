//Write a small function that returns the values of an array that are not odd.
//All values in the array will be integers. Return the good values in the order they are given.

namespace No_oddities_here
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces: ");
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] result = NoOddities.NoOdds(inputArray);

            Console.WriteLine("Values that are not odd:");
            foreach (var value in result)
            {
                Console.Write($"{value} ");
            }
        }
    }
    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            List<int> arr = new();
            foreach (int v in values)
            {
                if (v % 2 == 0)
                {
                    arr.Add(v);
                }
            }
            return arr.ToArray();
        }
    }
}