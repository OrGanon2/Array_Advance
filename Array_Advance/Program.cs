using System;

namespace Array_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Multiply_board = new int[10,10];

            for (int i = 1; i <= Multiply_board.GetLength(0); i++)
            {
                for (int j = 1; j <= Multiply_board.GetLength(1); j++)
                {
                    Console.Write(i * j + "\t");
                }
            }   Console.WriteLine();
        }
    }
}
