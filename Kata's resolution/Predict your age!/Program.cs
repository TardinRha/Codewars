//My grandfather always predicted how old people would get, and right before he passed away he revealed his secret!
//In honor of my grandfather's memory we will write a function using his formula!

namespace Predict_your_age_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ages of your eight great-grandparents (separated by spaces): ");
            string[] inputAges = Console.ReadLine().Split(' ');

            if (inputAges.Length != 8)
            {
                Console.WriteLine("Please enter exactly eight ages.");
                return;
            }

            int[] ages = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (!int.TryParse(inputAges[i], out ages[i]))
                {
                    Console.WriteLine("Invalid input. Please enter valid integer ages.");
                    return;
                }
            }

            Console.WriteLine($"Predicted age: {Predicter.PredictAge(ages[0], ages[1], ages[2], ages[3], ages[4], ages[5], ages[6], ages[7])}");
        }
    }
    public class Predicter
    {
        public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
        {
            return (int)Math.Sqrt((age1 * age1) + (age2 * age2) + (age3 * age3) + (age4 * age4) + (age5 * age5) + (age6 * age6) + (age7 * age7) + (age8 * age8)) / 2;
        }
    }
}