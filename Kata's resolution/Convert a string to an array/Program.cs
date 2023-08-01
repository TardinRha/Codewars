//Write a function to split a string and convert it into an array of words.

namespace Convert_a_string_to_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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