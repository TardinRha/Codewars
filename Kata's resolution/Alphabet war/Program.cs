//Write a function that accepts fight string consists of only small letters and return who wins the fight.
//When the left side wins return Left side wins!, when the right side wins return Right side wins!,
// in other case return Let's fight again!.

namespace Alphabet_war
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the fight string (consisting of only small letters): ");
            Console.WriteLine(Kata.AlphabetWar(Console.ReadLine()));
        }
    }
    public class Kata
    {
        public static string AlphabetWar(string fight)
        {
            int left = 0;
            int right = 0;
            foreach (char c in fight)
            {
                switch (c)
                {
                    case 'w': left += 4; break;
                    case 'p': left += 3; break;
                    case 'b': left += 2; break;
                    case 's': left += 1; break;
                    case 'm': right += 4; break;
                    case 'q': right += 3; break;
                    case 'd': right += 2; break;
                    case 'z': right += 1; break;
                    default: break;
                }
            }
            if (left > right)
            { return "Left side wins!"; }
            if (left < right)
            { return "Right side wins!"; }
            return "Let's fight again!";
        }
    }
}