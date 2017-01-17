using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int first = 0; first < n - 2; first++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                for (int row = 0; row < n - 2; row++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }
            Console.Write("+");
            for (int last = 0; last < n - 2; last++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
