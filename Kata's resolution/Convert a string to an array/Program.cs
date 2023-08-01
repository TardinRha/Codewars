//Write a function to split a string and convert it into an array of words.

namespace Convert_a_string_to_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a phrase to turn it into an array : ");
            string[] wordsArray = Solution.StringToArray(Console.ReadLine());

            Console.WriteLine("Word array:");
            foreach (string word in wordsArray)
            {
                Console.WriteLine(word);
            }
        }
    }
    public class Solution
    {
        public static string[] StringToArray(string str)
        {
            string[] palavras = str.Split(" ");
            return palavras;
        }
    }
}