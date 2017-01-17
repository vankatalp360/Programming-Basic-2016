using System;

namespace _14.NumberTable
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    num = row + col + 1;
                    if (num <= n)
                    {
                        Console.Write("{0} ", num);
                    }
                    if (num > n)
                    {
                        num = 2 * n - num;
                        Console.Write("{0} ", num);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
