//In this kata you will create a function that takes in a list and returns a list with the reverse order.

namespace Reverse_List_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resp;
            List<int> list = new();
            do
            {
                Console.WriteLine("Enter a number to add to a list");
                list.Add(int.Parse(Console.ReadLine()));
                Console.Write("Add one more item (y/n)? ");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 'y');
            Console.WriteLine("List with the reverse order: ");
            ReverseList(list);

        }
        public static void ReverseList(List<int> list)
        {
            List<int> reversedList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }
            Console.WriteLine(reversedList);
        }
    }
}