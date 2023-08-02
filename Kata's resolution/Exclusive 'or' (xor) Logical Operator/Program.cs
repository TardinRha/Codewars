//Since we cannot define keywords in Javascript (well, at least I don't know how to do it), your task is to define a function xor(a, b) where a and b are the two expressions to be evaluated. Your xor function should have the behaviour described above, returning true if exactly one of the two expressions evaluate to true, false otherwise.

namespace Exclusive__or___xor__Logical_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first boolean value (true or false): ");
            bool value1 = bool.Parse(Console.ReadLine());
            Console.Write("Enter the second boolean value (true or false): ");
            bool value2 = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Result of XOR operation: {Kata.Xor(value1, value2)}");
        }
    }
    public class Kata
    {
        public static bool Xor(bool a, bool b)
        {
            return a == b ? false : true;
        }
    }
}