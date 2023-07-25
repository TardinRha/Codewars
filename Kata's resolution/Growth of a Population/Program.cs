//In a small town the population is p0 = 1000 at the beginning of a year.
//The population regularly increases by 2 percent per year and moreover 50 new inhabitants per year come to live in the town.
//How many years does the town need to see its population greater or equal to p = 1200 inhabitants?

namespace Growth_of_a_Population
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p0 = 1000;      // Initial population
            double percent = 2; // Percentage increase per year
            int aug = 50;       // Number of new inhabitants per year
            int p = 1200;       // Target population
            Console.WriteLine($"The town needs {Arge.NbYear(p0, percent, aug, p)} years to reach a population of {p} inhabitants.");
        }
    }
    class Arge
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int n = 0;
            for (int i = 1; p0 < p; i++)
            {
                p0 = p0 + (int)(p0 * (percent / 100)) + aug;
                n = i;
            }
            return n;
        }
    }
}