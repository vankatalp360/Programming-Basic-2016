using System;

namespace _05.Ракета
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double width = 3 * N;
            int up = N;
            int mid = 1;
            int body = 2 * N;
            int down = N / 2;
            int first = N / 2;
            double second = (width - (N / 2)) - 1;
            double firstup = (width / 2) - 1;
            double secondup = (width / 2);

            for (int rowup = 0; rowup < up; rowup++)
            {
                for (int colup = 0; colup < width; colup++)
                {
                    if (colup == firstup)
                    {
                        Console.Write("/");
                    }
                    else if (colup == secondup)
                    {
                        Console.Write("\\");
                    }
                    else if (colup > firstup && colup < secondup)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                firstup -= 1;
                secondup += 1;
                Console.WriteLine();
            }
            for (int rowmid = 0; rowmid < mid; rowmid++)
            {
                for (int colmid = 0; colmid < width; colmid++)
                {
                    if (colmid >= first && colmid <= second)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            for (int rowbody = 0; rowbody < body; rowbody++)
            {
                for (int colbody = 0; colbody < width; colbody++)
                {
                    if (colbody == first || colbody == second)
                    {
                        Console.Write("|");
                    }
                    else if (colbody > first && colbody < second)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            for (int rowdown = 0; rowdown < down; rowdown++)
            {
                for (int coldown = 0; coldown < width; coldown++)
                {
                    if (coldown == first)
                    {
                        Console.Write("/");
                    }
                    else if (coldown == second)
                    {
                        Console.Write("\\");
                    }
                    else if (coldown > first && coldown < second)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                first -= 1;
                second += 1;
                Console.WriteLine();
            }
        }
    }
}
