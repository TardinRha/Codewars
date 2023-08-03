//Complete the function that receives as input a string, and produces outputs according to the following table.

namespace L1_Bartender__drinks_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a profession: ");
            string profession = Console.ReadLine();
            Console.WriteLine($"Recommended drink: {Kata.GetDrinkByProfession(profession)}");
        }
    }
    public class Kata
    {
        public static string GetDrinkByProfession(string p)
        {
            switch (p.ToLower())
            {
                case "jabroni": return "Patron Tequila";
                case "school counselor": return "Anything with Alcohol";
                case "programmer": return "Hipster Craft Beer";
                case "bike gang member": return "Moonshine";
                case "politician": return "Your tax dollars";
                case "rapper": return "Cristal";
                default: return "Beer";
            }
        }
    }
}