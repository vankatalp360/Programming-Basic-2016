using System;

namespace _05.Брадва
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int width = 5 * N;
            int rows = 2 * N;
            int first = (3 * N) + 1;
            int second = (3 * N) + 2;
            int midsecond = 0;
            int up = N;
            int mid = N / 2;
            int down = N / 2;

            for (int rowup = 1; rowup <= up; rowup++)
            {
                for (int colup = 1; colup <= width; colup++)
                {
                        if (colup == first || colup == second)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                        midsecond = second - 1;
                }
                second += 1;
                Console.WriteLine();
            }
            for (int rowmid = 0; rowmid < mid; rowmid++)
            {
                for (int colmid = 0; colmid < width; colmid++)
                {
                    if (colmid < first)
                    {
                        Console.Write("*");
                    }
                    else if (colmid == midsecond)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            first = first - 1;
            for (int rowdown = 0; rowdown < (mid - 1); rowdown++)
            {
                for (int coldown = 0; coldown < width; coldown++)
                {
                    if (coldown == first || coldown == midsecond)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                first -= 1;
                midsecond += 1;
                Console.WriteLine();
            }
            first -= 1;
            midsecond += 1;
            for (int collast = 0; collast < width; collast++)
            {
                if (collast > first && collast < midsecond)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }
}
