//Your harried co-workers are looking to you for a solution to take this garbled text and remove all of the numbers. Your program will take in a string and clean out all numeric characters, and return a string with spacing and special characters ~#$%^&!@*():;"'.,? all intact.

using System.Text.RegularExpressions;

namespace String_cleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text you want to correct: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Cleaned string: {Kata.StringClean(input)}");
        }
    }
    public class Kata
    {
        public static string StringClean(string s)
        {
            return Regex.Replace(s, @"\d", "");
        }
    }
}