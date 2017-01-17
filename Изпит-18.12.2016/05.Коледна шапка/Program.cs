using System;

namespace _05.Коледна_шапка
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double shir = (4 * N) + 1;
            double coll = 2 * N + 5;
            double upfirst = N * 2;
            double upsecond = upfirst + 2;
            double midfirst = N * 2;
            double midsecond = midfirst + 2;
            double firstmid = N * 2;
            double secmid = firstmid + 2;

            for (int rowup = 1; rowup <= 2; rowup++)
            {
                for (int colup = 1; colup <= shir; colup++)
                {
                    if (colup == upfirst)
                    {
                        if (rowup == 2)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                    else if (colup == upsecond)
                    {
                        if (rowup == 2)
                        {
                           Console.Write("/");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }
                    else if (colup > upfirst && colup < upsecond)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            for (int rowmid = 1; rowmid <= N * 2; rowmid++)
            {
                for (int colmid = 1; colmid <= shir; colmid++)
                {
                    if (colmid == midfirst)
                    {
                        Console.Write("*");
                    }
                    else if (colmid == midsecond)
                    {
                        Console.Write("*");
                    }
                    else if (colmid > midfirst && colmid < midsecond && rowmid == 1)
                    {
                        Console.Write("*");
                    }
                    else if (colmid == (N * 2 + 1))
                    {
                        Console.Write("*");
                    }
                    else if (colmid > midfirst && colmid < (N * 2 + 1))
                    {
                        Console.Write("-");
                    }
                    else if (colmid > (N * 2 + 1) && colmid < midsecond)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                midfirst -= 1;
                midsecond += 1;
                Console.WriteLine();
            }
            for (int rowdoun = 1; rowdoun <= 3; rowdoun++)
            {
                for (int coldoun = 1; coldoun <= shir; coldoun++)
                {
                    if (rowdoun == 1)
                    {
                        Console.Write("*");
                    }
                    else if (rowdoun == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (coldoun % 2 != 0)
                        {
                            Console.Write("*");
                        }
                        if (coldoun % 2 == 0)
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
