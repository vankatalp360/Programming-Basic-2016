using System;

namespace _02.RectangleOfNxNStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 1; col <= n; col++)
            {
                for (int row = 1; row <= n; row++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
