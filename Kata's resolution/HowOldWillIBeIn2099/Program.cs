//Philip's just turned four and he wants to know how old he will be in various years in the future such as 2090 or 3044.
//His parents can't keep up calculating this so they've begged you to help them out by writing a programme that can answer
//Philip's endless questions.
//Your task is to write a function that takes two parameters: the year of birth and the year to count years in relation to.
//As Philip is getting more curious every day he may soon want to know how many years it was until he would be born, so your
//function needs to work with both dates in the future and in the past.

namespace HowOldWillIBeIn2099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the year you want to calculate your age for: ");
            int yearToCalculate = int.Parse(Console.ReadLine());

            Console.WriteLine(AgeDiff.CalculateAge(birthYear, yearToCalculate));
        }
    }
    public static class AgeDiff
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            if (yearTo > birth)
            {
                return (yearTo - birth) < 2 ? $"You are {yearTo - birth} year old." : $"You are {yearTo - birth} years old.";
            }
            if (birth > yearTo)
            {
                return (birth - yearTo) < 2 ? $"You will be born in {birth - yearTo} year." : $"You will be born in {birth - yearTo} years.";
            }
            return "You were born this very year!";
        }
    }
}