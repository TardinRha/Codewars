//Think of a way to store the languages as a database (eg an object). The languages are listed below so you can copy and paste!
//Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. It should default to English if the language is not in the database, or in the event of an invalid input.

namespace Welcome_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a language: ");
            string language = Console.ReadLine();
            Console.WriteLine(Kata.Greet(language));
        }
    }
    public static class Kata
    {
        public static string Greet(string language)
        {
            Dictionary<string, string> cumprimento = new Dictionary<string, string>()
          {
            {"english", "Welcome"},
            {"czech", "Vitejte"},
            {"danish", "Velkomst"},
            {"dutch", "Welkom"},
            {"estonian", "Tere tulemast"},
            {"finnish", "Tervetuloa"},
            {"flemish", "Welgekomen"},
            {"french", "Bienvenue"},
            {"german", "Willkommen"},
            {"irish", "Failte"},
            {"italian", "Benvenuto"},
            {"latvian", "Gaidits"},
            {"lithuanian", "Laukiamas"},
            {"polish", "Witamy"},
            {"spanish", "Bienvenido"},
            {"swedish", "Valkommen"},
            {"welsh", "Croeso"}
          };
            if (!cumprimento.ContainsKey(language))
            { language = "english"; }
            return $"{cumprimento[language]}";
        }
    }
}