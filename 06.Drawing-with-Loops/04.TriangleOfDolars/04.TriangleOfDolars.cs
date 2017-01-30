using System;

namespace _04.TriangleOfDolars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write("$");
                for (int col = 1; col < row; col ++)
                {
                    if (row != 1)
                    {
                        Console.Write(" $");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
