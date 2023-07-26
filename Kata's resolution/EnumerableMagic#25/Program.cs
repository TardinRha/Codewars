//Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the list/array.

namespace EnumerableMagic_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by spaces: ");
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Enter the number of elements to take: ");
            int n = int.Parse(Console.ReadLine());

            int[] result = Kata.Take(inputArray, n);

            Console.Write("First n elements from the list: ");
            foreach (var element in result)
            {
                Console.Write($"{element} ");
            }
        }
    }
    public static class Kata
    {
        public static int[] Take(int[] arr, int n)
        {
            if (arr == null || arr.Length == 0) { return new int[] { }; }
            if (n > arr.Length) { n = arr.Length; }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = arr[i];
            }
            return a;
        }
    }
}