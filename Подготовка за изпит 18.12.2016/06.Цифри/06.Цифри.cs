using System;

namespace _06.Цифри
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int row = 0;
            int nums = 0;
            int first = 0;
            int second = 0;
            int third = 0;

            first = (num % 1000) / 100;
            second = (num % 100) / 10;
            third = num % 10;

            row = first + second;
            nums = first + third;

            for (int rows = 1; rows <= row; rows++)
            {
                for (int numss = 1; numss <= nums; numss++)
                {
                    if (num % 5 == 0)
                    {
                        num = num - first;
                    }
                    else if (num % 3 == 0)
                    {
                        num = num - second;
                    }
                    else
                    {
                        num = num + third;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
