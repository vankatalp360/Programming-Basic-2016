using System;

namespace _03.SquareOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 1; col <= n; col++)
            {
                Console.Write("*");
                for (int row = 1; row < n; row++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
