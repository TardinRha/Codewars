//You get any card as an argument. Your task is to return the suit of this card (in lowercase).

namespace Define_a_card_suit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a card: ");
            Console.WriteLine(Kata.DefineSuit(Console.ReadLine()));
        }
    }
    public partial class Kata
    {
        public static string DefineSuit(string card)
        {
            switch (card[card.Length - 1])
            {
                case '♣': return "clubs";
                case '♦': return "diamonds";
                case '♥': return "hearts";
                case '♠': return "spades";
                default: break;
            }
            return "";
        }
    }
}