using System;

namespace _05.Лисица
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            int left = 1;
            int right = width - 2;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == left)
                    {
                        Console.Write("\\");
                    }
                    else if (col == right)
                    {
                        Console.Write("/");
                    }
                    else if (col > left && col < right)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                left++;
                right--;
                Console.WriteLine();
            }

            int eye = n / 3;
            int noseleft = ((width - n) / 2) - 1;
            int noseright = (width - noseleft) - 1;
            for (int row = 0; row < eye; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == 0 || col == width - 1)
                    {
                        Console.Write("|");
                    }
                    else if (col == noseleft)
                    {
                        Console.Write("\\");
                    }
                    else if (col == noseright)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                noseleft++;
                noseright--;
                Console.WriteLine();
            }

            left = 1;
            right = width - 2;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == left)
                    {
                        Console.Write("\\");
                    }
                    else if (col == right)
                    {
                        Console.Write("/");
                    }
                    else if (col > left && col < right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                left++;
                right--;
                Console.WriteLine();
            }
        }
    }
}
