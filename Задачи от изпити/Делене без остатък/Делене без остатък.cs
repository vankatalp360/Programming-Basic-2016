using System;

namespace Делене_без_остатък
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal p1 = 0;
            decimal p2 = 0;
            decimal p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1 += 1;
                }
                if (num % 3 == 0)
                {
                    p2 += 1;
                }
                if (num % 4 == 0)
                {
                    p3 += 1;
                }
            }
            p1 = Math.Round(p1 / n * 100, 2);
            p2 = Math.Round(p2 / n * 100, 2);
            p3 = Math.Round(p3 / n * 100, 2);

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
        }
    }
}
