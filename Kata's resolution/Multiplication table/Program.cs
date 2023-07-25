//Your task, is to create N×N multiplication table, of size provided in parameter.

namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the multiplication table: ");
            int[,] multiplicationTable = MultiplicationTable(int.Parse(Console.ReadLine()));

            Console.WriteLine("Tabela de Multiplicação:");
            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                for (int j = 0; j < multiplicationTable.Length; j++)
                {
                    Console.Write("{0,4}", multiplicationTable[i, j]);
                }
            }
        }
        public static int[,] MultiplicationTable(int size)
        {
            int[,] table = new int[size, size];
            int multiplier = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    table[i, j] = (j + 1) * multiplier;
                }
                multiplier++;
            }
            return table;
        }
    }


}