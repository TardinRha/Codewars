//Your task is simply to count the total number of lowercase letters in a string.

namespace Regex_count_lowercase_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your word or text to count the total number of lowercase letters:");
            string wordOrText = Console.ReadLine();
            Console.Write($"Small letters: {LowercaseCountCheck(wordOrText)}");
        }
        public static int LowercaseCountCheck(string s)
        {
            int count = 0;
            foreach (char l in s)
            {
                if (char.IsLower(l))
                {
                    count++;
                }
            }
            return count;
        }
    }
}