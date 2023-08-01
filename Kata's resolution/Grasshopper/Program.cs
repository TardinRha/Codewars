//In this game, the hero moves from left to right. The player rolls the dice and moves the number of spaces indicated by the dice two times.
//Create a function for the terminal game that takes the current position of the hero and the roll (1-6) and return the new position.

namespace Grasshopper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the current position of the hero: ");
            int currentPosition = int.Parse(Console.ReadLine());

            Console.Write("Enter the roll (1-6): ");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine($"New position of the hero: {Game.Move(currentPosition, roll)}");
        }
    }
    public class Game
    {
        public static int Move(int position, int roll)
        {
            return position + (roll * 2);
        }
    }
}