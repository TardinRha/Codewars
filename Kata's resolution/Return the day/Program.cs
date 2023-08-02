//Complete the function which returns the weekday according to the input number:
//1 returns "Sunday"; 2 returns "Monday"; 3 returns "Tuesday"; 4 returns "Wednesday"; 5 returns "Thursday"; 6 returns "Friday"; 7 returns "Saturday"; Otherwise returns "Wrong, please enter a number between 1 and 7"

namespace Return_the_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 7: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Weekday: {Kata.WhatDay(number)}");
        }
    }
    public class Kata
    {
        public static string WhatDay(int n)
        {
            return n == 1 ? "Sunday" :
            n == 2 ? "Monday" :
            n == 3 ? "Tuesday" :
            n == 4 ? "Wednesday" :
            n == 5 ? "Thursday" :
            n == 6 ? "Friday" :
            n == 7 ? "Saturday" : "Wrong, please enter a number between 1 and 7";
        }
    }
}