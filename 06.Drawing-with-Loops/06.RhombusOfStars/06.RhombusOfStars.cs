using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                for (int i = 1; i <= (row - 1); i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int second = 2; second <= n; second++)
            {
                Console.Write(new string(' ', second - 1));
                Console.Write("*");
                for (int i = 1; i <= (n - second); i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
