using System;

namespace _09.House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int row1 = (n + 1) / 2;

            for (int row = 0; row < row1; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col % 2 != 0 && row == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine("**");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
