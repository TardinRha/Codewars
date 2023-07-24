//Your task, is to create N×N multiplication table, of size provided in parameter.

namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da tabela de multiplicação: ");
            int size = int.Parse(Console.ReadLine());

            int[,] multiplicationTable = MultiplicationTable(size);

            Console.WriteLine("Tabela de Multiplicação:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,4}", multiplicationTable[i, j]);
                }
            }
        }
        public static int[,] MultiplicationTable(int size)
        {
            int[,] table = new int[size, size];
            int v = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    table[i, j] = (j + 1) * v;
                }
                v++;
            }
            return table;
        }
    }


}