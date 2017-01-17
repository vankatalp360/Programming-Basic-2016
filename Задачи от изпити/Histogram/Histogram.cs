using System;

namespace Histogram
{
    class Histogram
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal p1 = 0;
            decimal p2 = 0;
            decimal p3 = 0;
            decimal p4 = 0;
            decimal p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 += 1;
                }
                else if ((num >= 200) && (num <= 399))
                {
                    p2 += 1;
                }
                else if ((num >= 400) && (num <= 599))
                {
                    p3 += 1;
                }
                else if ((num >= 600) && (num <= 799))
                {
                    p4 += 1;
                }
                else if (num >= 800)
                {
                    p5 += 1;
                }
            }
            p1 = Math.Round(p1 / n * 100, 2);
            p2 = Math.Round(p2 / n * 100, 2);
            p3 = Math.Round(p3 / n * 100, 2);
            p4 = Math.Round(p4 / n * 100, 2);
            p5 = Math.Round(p5 / n * 100, 2);

            Console.WriteLine("{0}%", p1);
            Console.WriteLine("{0}%", p2);
            Console.WriteLine("{0}%", p3);
            Console.WriteLine("{0}%", p4);
            Console.WriteLine("{0}%", p5);
        }
    }
}
